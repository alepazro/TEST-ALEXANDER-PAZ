# Usa una imagen de node como base
FROM node:16-alpine

# Establece el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copia los archivos package.json y package-lock.json
COPY package*.json ./

# Instala las dependencias del proyecto
RUN npm install

# Copia todos los archivos del proyecto al contenedor
COPY . .

# Construye la aplicación para producción
RUN npm run build

# Expone el puerto que la aplicación utilizará
EXPOSE 3000

# Comando para iniciar el servidor de producción usando serve (puedes usar otro servidor si lo prefieres)
CMD ["npx", "serve", "build", "-s", "-l", "3000"]
