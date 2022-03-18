# CALC-POLATION ₂₀₂₂

_Una calculadora de interpolación lineal, cuadrática y Polinomios de Lagrange._
![Logotipo Alternativo](https://i.ibb.co/rZxm09P/Logotipo-Alternative.png)
## Comenzando

_Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo y pruebas (estas instrucciones pueden fallar)._

### Pre-requisitos

* Para ejecutar correctamente la aplicación deberás tener instalado [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0/runtime) _(indispensable)_
* Para usarios que quieran usar la aplicación deben dirigirse al apartado **Run desktop apps** y descargar el framework dependiendo de la arquitectura de tu sistema.

## Construido con

_Se utilizó la siguiente herramienta para el desarrollo del proyecto:_

* [FontAwesome.Sharp v5.15.4](http://www.dropwizard.io/1.0.2/docs/) - Usado para estilos de botones con iconos.

## Contribuyendo

_Usamos [LiveShare](https://visualstudio.microsoft.com/es/services/live-share/) por parte de los desarolladores de la aplicación para el desarrollo colaborativo._

## Cómo usar
* _Estas instrucciones te ayudarán a familiarizarte con la aplicación de manera sencilla._
### Panel lateral
* _Dentro del **panel lateral** se mostrarán una serie de botones cuyas funciones son las siguientes:_

![Panel](https://i.ibb.co/QbkghG4/1.png)

### Interpolación
* _Esta sección te ayuda a resolver problemas de interpolación lineal y cuadrática de manera rápida._
* _Al hacer click desplegará **2 submenús** en el cual hay 2 opciones disponibles:_

![Image text](https://i.ibb.co/MPqg9qx/2.png)

#### **Lineal y Cuadrática**

![Interpolación menú](https://i.ibb.co/P1CLyJx/2-1.png)

* **NOTA:** _A PARTIR DE ESTA NOTA, LOS BOTONES DE OPCIONES, CASILLAS, CUADROS DE TEXTO Y CUADRO DE RESULTADOS **APLICARÁ GLOBALMENTE** EN INTERPOLACIÓN LINEAL, CUADRÁTICA Y POLINOMIOS DE LAGRANGE_

##### Botones de opciones
* **Calcular** - _Calcula la interpolación lineal o cuadrática tomando los valores de la parte inferior de la aplicación_
* **Reiniciar** - _Limpia los valores y los **restablece a 0**_

##### Casillas de verificación y botones circulares
* **Calcular error relativo porcentual** - _Calcula el error relativo porcentual tomando los valores de Vv (valor verdadero) y Vapx (valor aproximado)_

![Error relativo porcentual](https://i.ibb.co/1sBfvNw/4.png)

* **Sin redondear** - _El resultado obtenido es **largo** y puede contener muchos decimales_
* **Redondear** - _El resultado obtenido serán **únicamente enteros**, es decir, sin decimales (si el resultado es 1.4 no se redondea, en cambio si el decimal es mayor que 5 entonces el resultado de 1.5 sería 2)_
* **Últimos 4 decimales** - _El resultado obtenido toma los números enteros y **4 decimales** (como la primera función "Sin Redondear" pero resumido)_

##### Campos de texto y resultados
* **Campos o cuadros** - _Se **introducen números** positivos, negativos, enteros y/o decimales que representan a cada elemento de la fórmula seleccionada_
* **Cuadro de resultados** - _Aparece a la derecha de las opciones y te muestra el resultado obtenido, así como también la fórmula y el procedimiento por pasos_

### Polinomios de Lagrange
* _Esta sección te ayuda a resolver problemas de polinomios de Lagrange de 1ra y 2da orden de manera rápida._

![Polinomios de Lagrange](https://i.ibb.co/7S6FR5P/2-2.png)

##### Casillas de verificación y botones circulares
* **Primer orden** - _Calcula los polinomios de **Lagrange de 1er Orden** de acuerdo a la fórmula tomando los valores X, X₀, X₁, f(x₀) y f(x₁)_
* **Segunda orden** - _Calcula los polinomios de **Lagrange de 2da Orden** de acuerdo a la fórmula tomando los valores X, X₀, X₁, X₂, f(x₀), f(x₁) y f(x₂)_

### Ayuda
* _Esta sección te ayuda a resolver dudas y obtener más información acerca de los creadores de la aplicación._
* _Al hacer click desplegará **2 submenús** en el cual hay 2 opciones disponibles:_

![Ayuda menú](https://i.ibb.co/nb1DtCj/3.png)

#### **Cómo usar**
* _El botón te redirigirá a esta guía para saber cómo usar y cómo funciona cada una de las partes de la aplicación_

#### **Acerca de**
##### Créditos
* _Se abrirá una nueva ventana con los datos de los creadores de la aplicación y un pequeño mensaje que debe cumplirse_

![Image text](https://i.ibb.co/R054tXf/3-1.png)

* _**NOTA:** LA APLICACIÓN ES UN TRABAJO ACADÉMICO Y DEBE TOMARSE COMO TAL, NI EL LOGOTIPO NI LA APLICACIÓN ESTÁN REGISTRADOS ACTUALMENTE, **SOLO DEBERÁ USARSE PARA FINES ACADÉMICOS**, SU VENTA NO SERÁ PERMITIDA_

### Lanzamientos
* _Te redirigirá a los [tags de este repositorio](https://github.com/JohnyDeCoder/calc-polation/tags) que son nuevas versiones disponibles para descargar de la aplicación._

### Salir
* _Se cerrará la aplicación._

## Versionado

Usamos [SemVer](http://semver.org/) para el versionado. Para todas las versiones disponibles, mira los [tags de este repositorio](https://github.com/JohnyDeCoder/calc-polation/tags).

## Autores

* **Johny Mora** - *Trabajo Inicial y Documentación* - [JohnyDeCoder](https://github.com/JohnyDeCoder)
* **Brandon Moran** - *Colaborador* - [BrandonMoran11](https://github.com/BrandonMoran11)

## BetaTesters

_¡Les damos las gracias por el apoyo recibido!_

* **Rogelio Martínez** - *BetaTester*
* **Ángel Verduzco** - *BetaTester*
* **Luis Antonio** - *BetaTester*
* **Salvador Piñón** - *BetaTester*
* **Julián Ramírez** - *BetaTester*

## Licencia

Este proyecto está bajo la Licencia GNU General Public License v3.0 - mira el archivo [LICENSE](https://github.com/JohnyDeCoder/calc-polation/blob/master/LICENSE) para más detalles.

## Expresiones de Gratitud

* _Muchísimas gracias a los **BetaTesters** por probar nuestra aplicación._
