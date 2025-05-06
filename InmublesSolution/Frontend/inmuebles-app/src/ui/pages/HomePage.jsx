import React, { useEffect, useState } from "react";
import { getFilteredPropertiesService } from "../../application/services/propertyService"; // Asegúrate de tener esta función implementada
import "../../styles/app.css";

export const HomePage = () => {
  const [properties, setProperties] = useState([]);
  const [filters, setFilters] = useState({
    name: "",
    address: "",
    minPrice: "",
    maxPrice: "",
  });

  // Realizar la consulta inicial sin filtros cuando se carga la página
  useEffect(() => {
    const fetchProperties = async () => {
      try {
        const data = await getFilteredPropertiesService({});
        setProperties(data);
      } catch (err) {
        console.error("Error obteniendo propiedades:", err);
      }
    };

    fetchProperties();
  }, []); // Se ejecuta solo una vez cuando el componente se monta

  // Función para manejar los cambios en los filtros
  const handleChange = (e) => {
    setFilters({
      ...filters,
      [e.target.name]: e.target.value,
    });
  };

  // Función para aplicar los filtros al servicio
  const applyFilters = async () => {
    try {
      const data = await getFilteredPropertiesService(filters);
      setProperties(data);
    } catch (err) {
      console.error("Error aplicando filtros:", err);
    }
  };

  // Limpiar los filtros
  const clearFilters = () => {
    setFilters({
      name: "",
      address: "",
      minPrice: "",
      maxPrice: "",
    });
  };

  // Función para dividir las propiedades en grupos de 5
  const chunkProperties = (properties) => {
    const chunkSize = 3;
    const chunks = [];
    for (let i = 0; i < properties.length; i += chunkSize) {
      chunks.push(properties.slice(i, i + chunkSize));
    }
    return chunks;
  };

  return (
    <div className="home-container">
      <h1>Propiedades</h1>

      {/* 🎛️ Filtros */}
      <div className="filter-container">
        <input
          type="text"
          name="name"
          placeholder="Buscar por nombre"
          value={filters.name}
          onChange={handleChange}
        />
        <input
          type="text"
          name="address"
          placeholder="Buscar por dirección"
          value={filters.address}
          onChange={handleChange}
        />
        <input
          type="number"
          name="minPrice"
          placeholder="Precio mínimo"
          value={filters.minPrice}
          onChange={handleChange}
        />
        <input
          type="number"
          name="maxPrice"
          placeholder="Precio máximo"
          value={filters.maxPrice}
          onChange={handleChange}
        />
      </div>

      {/* Botón para aplicar los filtros */}
      <button className="apply-filters-btn" onClick={applyFilters}>
        Aplicar Filtros
      </button>

      {/* Botón para limpiar los filtros */}
      <button className="clear-filters-btn" onClick={clearFilters}>
        Limpiar Filtros
      </button>

      {/* 🏠 Lista de propiedades */}
      <div className="property-list">
        {properties.length === 0 ? (
          <p>No se encontraron propiedades.</p>
        ) : (
          chunkProperties(properties).map((propertyRow, rowIndex) => (
            <div key={rowIndex} className="property-row">
              {propertyRow.map((prop) => (
                <div key={prop.id} className="property-card">
                  <h2 className="property-title">{prop.name}</h2>
                  <p className="property-address">{prop.address}</p>
                  <p className="property-price">${prop.price}</p>
                  <div className="main-image">
                    <img
                      src={prop.images[0]?.file}
                      alt="Imagen principal"
                      style={{ width: "100%", height: 300, objectFit: "cover" }}
                    />
                  </div>
                </div>
              ))}
            </div>
          ))
        )}
      </div>
    </div>
  );
};
