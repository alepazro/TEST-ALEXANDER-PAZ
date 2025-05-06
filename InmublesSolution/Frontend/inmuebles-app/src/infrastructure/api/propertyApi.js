export const fetchFilteredProperties = async (filters) => {
    const query = new URLSearchParams();
  
    if (filters.name) query.append("Name", filters.name);
    if (filters.address) query.append("Address", filters.address);
    if (filters.minPrice) query.append("MinPrice", filters.minPrice);
    if (filters.maxPrice) query.append("MaxPrice", filters.maxPrice);
  
    const res = await fetch(
      `https://localhost:5001/api/Property/images?${query.toString()}`
    );
  
    if (!res.ok) throw new Error("Error al obtener propiedades filtradas");
  
    return await res.json();
  };
  