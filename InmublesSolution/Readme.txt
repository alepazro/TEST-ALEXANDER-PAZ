PRESENTADO POR ALEXANDER DAVID PAZ
INGENIERO DE SISTEMAS Y ESPECIALISTA EN PROCESOS DE DESARROLLO DE SOFTWARE.

REQUERIMIENTO:
Usuario solicita crear una aplicación 360 implementando mejores practicas de arquitectura y codificación para una aplicación web que permita a los usuarios ver 
las propiedades disponibles según criterios de búsqueda (precio,nombre,dirección).


Se crea una API en .netCore para implementar el Backend que soporte las peticiones de la aplicación web.
Se crea base de datos en mongoDB y se crean fakedata para realizar pruebas desde la aplicación.
se crea app web con react.js para visualizar las propiedades aplicando estilos Css para una mejor visualización.

Adicional, se configura un certificado de seguridad ssl local para poder usar https en las peticiones web y se monta al contenedor de la api.
Se utiliza Swagger para la documentación de la API.

La implementación realizada se coloca en contenedores de docker para una mayor facilidad al momento de desplegar los proyectos por medio de un docker-compose.yml.
contenedores: 
mongo_db
inmuebles-api https://localhost:5001/swagger/index.html
react-app http://localhost:3000/


Para ejecutar el proyecto, se debe hacer lo siguiente.
1. descomprimir el archivo .zip en una ubicación del disco.
2. ingresar al proyecto por cmd a la ruta Frontend/inmuebles-app y ejecutar el comando para instalar las dependencias de node.
 npm install 
3. Abrir el cmd en la ubicación donde se encuentra el archivo docker-compose.yml - utilizar command-prompt
4. ejecutar el comando para levantar los contenedores.
docker-compose up -d 

5. ejecutar el comando para cargar los fakedata en la base de datos de mongo.
docker exec -i mongo_db mongosh < DB_init.js 

6. ingresar a http://localhost:3000/ y se deben visualizar las propiedades existentes en la base de datos.

Requisito:
Debe estar instalado Docker en el computador según el sistema operativo.


