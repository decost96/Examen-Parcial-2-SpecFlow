# language: es
Característica: Constructor
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](DavidSpecFlowTest/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Escenario: Crear Persona
	Dado el nombre es "David"
	Y el apellido es "Costa"
	Y el numero de cedula "2300701980"
	Y la ocupacion "vendedor"
	Y el lugar de trabajo "QuiCentro Shopping"
	Y el horario "Matutino"
	Cuando las son variables son unidas 
	Entonces deberia notificar "persona creada correctamente"



