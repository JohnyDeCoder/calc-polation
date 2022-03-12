# CALC-POLATION ₂₀₂₂

_Una calculadora de interpolación lineal, cuadrática y Polinomios de Lagrange._
![Image text](https://i.ibb.co/rZxm09P/Logotipo-Alternative.png)
## Comenzando

_Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo y pruebas._

### Pre-requisitos

* Para ejecutar correctamente la aplicación deberás tener instalado [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0/runtime) _(indispensable)_
* Para usarios que quieran usar la aplicación deben dirigirse al apartado **Run desktop apps** y descargar el framework dependiendo de la arquitectura de tu sistema.

## Construido con

_Se utilizó la siguiente herramienta para el desarrollo del proyecto:_

* [FontAwesome.Sharp v5.15.4](http://www.dropwizard.io/1.0.2/docs/) - Usado para estilos de botones con iconos.

## Contribuyendo

_Se utilizó [LiveShare](https://visualstudio.microsoft.com/es/services/live-share/) por parte de ambos desarolladores para el desarrollo de la aplicación._

## Cómo usar
### Panel
* Dentro *Panel* se mostrarán una serie de botones cuyas funciones son las siguientes:

![Image text](https://i.ibb.co/ZfJt2Xw/1.png)

### Interpolación
_Al hacer click desplegará 2 submenús en el cual hay 2 opciones:_

![Image text](https://i.ibb.co/MPqg9qx/2.png)

#### **Lineal y Cuadrática**

![Image text](https://i.ibb.co/P1CLyJx/2-1.png)

##### Botones
* **Calcular** - _Calcula la interpolación lineal tomando los valores en pantalla y siguiendo de acuerdo a la fórmula_
* **Reiniciar** - _Limpia los valores_

##### Casillas de verificación y botones circulares
* **Calcular error relativo porcentual** - _Calcula el error porcentual tomando el valor de X y f(x) (utilizado solo si el usuario conoce el valor verdadero de f(x)_
* **Sin redondear** - _El resultado obtenido puede ser largo con muchos decimales_
* **Redondear** - _El resultado obtenido se resume en un solo entero (si el resultado es 1.4 no se redondea, en cambio si el decimal es mayor que 5 entonces el resultado sería 2)_
* **Últimos 4 decimales** - _El resultado toma los números enteros y 4 decimales (como la función "Sin Redondear" pero resumido)_

##### Cuadros de textos y resultados
* **Campos** - _Se introducen números positivos, negativos, enteros y decimales que representan a cada elemento de la fórmula_
* **Cuadro de resultados** - _Te muestra el resultado obtenido, la fórmula y el procedimiento por pasos_

### Polinomios de Lagrange

![Image text](https://i.ibb.co/7S6FR5P/2-2.png)

##### Botones
* **Calcular** - _Calcula la interpolación lineal tomando los valores en pantalla y siguiendo de acuerdo a la fórmula_
* **Reiniciar** - _Limpia los valores_

##### Casillas de verificación y botones circulares
* **Calcular error relativo porcentual** - _Calcula el error porcentual tomando el valor de X y f(x) (utilizado solo si el usuario conoce el valor verdadero de f(x)_
* **Sin redondear** - _El resultado obtenido puede ser largo con muchos decimales_
* **Redondear** - _El resultado obtenido se resume en un solo entero (si el resultado es 1.4 no se redondea, en cambio si el decimal es mayor que 5 entonces el resultado sería 2)_
* **Últimos 4 decimales** - _El resultado toma los números enteros y 4 decimales (como la función "Sin Redondear" pero resumido)_
* **Primer orden** - _Calcula los polinomios de Lagrange de 1er Orden de acuerdo a la fórmula tomando los valores X, X₀, X₁, f(x₀), f(x₁)_
* **Segunda orden** - _Calcula los polinomios de Lagrange de 2da Orden de acuerdo a la fórmula tomando los valores X, X₀, X₁, X₂, f(x₀), f(x₁), f(x₂)_

##### Cuadros de textos y resultados
* **Campos** - _Se introducen números positivos, negativos, enteros y decimales que representan a cada elemento de la fórmula_
* **Cuadro de resultados** - _Te muestra el resultado obtenido, la fórmula y el procedimiento por pasos_

### Ayuda
_Al hacer click desplegará 2 submenús en el cual hay 2 opciones:_

![Image text](https://i.ibb.co/nb1DtCj/3.png)

#### **Cómo usar**
* _Te redirigirá a esta guía para saber cómo usar cada una de las partes de la aplicación_

#### **Acerca de**
##### Créditos

![Image text](https://i.ibb.co/R054tXf/3-1.png)

* _Se muestra en una nueva ventana el creador y el colaborador del proyecto junto con las formas de contacto y un aviso como el siguiente_
* _"Esta aplicación es un trabajo meramente académico, por lo tanto, sólo debe ser usado para fines académicos."_

### Repositorio
* _Te redirigirá a los [tags de este repositorio](https://github.com/JohnyDeCoder/calc-polation/tags)_

### Salir
* _Se cerrará la aplicación._

## Versionado

Usamos [SemVer](http://semver.org/) para el versionado. Para todas las versiones disponibles, mira los [tags en este repositorio](https://github.com/JohnyDeCoder/calc-polation/tags).

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

* Muchísimas gracias a los **BetaTesters** por probar nuestra aplicación.
