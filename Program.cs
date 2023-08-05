int [] numbers={1,2};
int factor=10;// capturamos esta variable a continuación:
var query=numbers.Select(n=>n*factor);
factor=20;  //Cambiar el valor de la variable capturada
foreach (var item in query)
Console.Write($"{item}|");
