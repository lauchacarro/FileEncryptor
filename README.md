# FileEncryptor
FileEncryptor es una aplicación para encriptar y desencriptar archivos.

## Motivación
Un compañero me preguntó si conocia alguna herramienta para encriptar archivos y mi respuesta fue "no conozco pero te puedo hacer una". Queria aprovechar hacer algun proyecto chico en WinForms y NET Core 3.0.

## Alcance
FileEncryptor es muy basica. Subis un archivo, ingresas la clave secreta para encriptar el archivo y te guarda en tu PC el mismo archivo pero encriptado. Y tenes la opción para descencriptar, subiendo el archivo encriptado e ingresando la misma clave secreta.

## Caracteristicas
- Encriptación basada en AES.
- WinForms con NET Core 3.0.
- Uso DebuggerDisplay.
- Todas las sentencias 'if' se encuentran en métodos de extensión.
- Cree los formularios con un diseñador de Winforms para NET Core. [Actualmente esta en preview. Es una extension de Visual Studio](https://github.com/dotnet/winforms/tree/master/Documentation/designer-releases)
- Los archivos encriptados los guarda con la extensión .lch y solo se podrá descencriptar archivos con esa extensión.

## TODO
- Migrar a Blazor.

## ScreenShots
![image](https://user-images.githubusercontent.com/28534415/69896835-35c2dc00-1322-11ea-8277-6c10945d38e7.png)

![image](https://user-images.githubusercontent.com/28534415/69896843-45dabb80-1322-11ea-8cc7-a9c91825c622.png)

![image](https://user-images.githubusercontent.com/28534415/69896734-766e2580-1321-11ea-8806-d312602147cf.png)
