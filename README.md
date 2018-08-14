# Khalos
Proyecto de Diseño y Desarrollo de Sistemas. Punto de venta para una boutique

# Autores
María Esther Marín Chacón
José Andrés Guzmán García
Shafiq Mora Campos

# Prerequisitos de instalación 
Para poder correr este software se requiere tomar en cuneta los siguientes aspectos:
1. Se requiere poseer Visual Studio 2017 para poder realizar las modificaciones y adptaciones pertinentes al codigo y
poder verlo en ejecucion.
2. Se requiere tener instalado el Sql Server para poder colocarla base de datos y junto con el Visual Studio poder realizar la conexión a esta misma y poder
ingresar,ver y eliminar datos de la base de datos.
3. Se requiere la aplicacion de GIT para que mediante la consola se puedan publicar los cambios al github mediante los comandos que se solicitan
para mantener las buenas practicas durante el desarrollo.

# Instalación
Para realizar la completa instalación se deben realizar los siguientes pasos:
1. Clonar el repositorio.
2. Crear una base de datos en sql Server.
3. Ejecutar el archivo de backup de la base de datos.
4. En Visual Studio cambiar las referencias a las referencias locales.
5. Correr el proyecto.

# Despliegue 
Para realizar un buen despliegue se tiene que tomar en cuenta que:
1. Si requiere agregar usuarios nuevos, con roles diferentes a los existentes
primero debe agregar el rol/es que requiera y luego insertar el usuario.
2. Si desea agregar artículos que contengan una categoría diferente a la existente, 
debe asegurarse de agregar dicha categoría. 
