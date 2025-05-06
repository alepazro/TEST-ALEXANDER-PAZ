import { fetchFilteredProperties } from "../../infrastructure/api/propertyApi";
import { Property } from "../../domain/models/Property";
import { Image } from "../../domain/models/Image";

export const getFilteredPropertiesService = async (filters) => {
  const data = await fetchFilteredProperties(filters);
  return data.map((d) =>
    new Property({
      ...d,
      images: d.images.map((img) => new Image(img)),
    })
  );
};
