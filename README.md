# PTISenac 3o período

Suponha que você precisa criar um sistema para uma locadora de veículos online 
utilizando programação orientada a objetos e a linguagem C#.
Precisamos criar uma classe chamada “Veiculo” que que abstraia todos as 
características e comportamentos dos veículos disponíveis para locação. Esta 
classe servirá como base para ser herdada por duas classes filhas, denominadas 
Carro e Moto.
A classe Veiculo foi definida como uma classe abstrata da seguinte forma:
public abstract class Veículo{
 protected double TaxaDiaria {get; set;}
 public abstract double CalcularValorTotal(int numDiarias);
}

Considerando que a taxa diária fixa de locação de um carro, independentemente do 
modelo é de 50 reais e a de moto de 25 reais:
A) Crie as classes Carro e Moto que herdam da classe Veculo. Crie um construtor 
que receba o valor da taxa como parâmetro. Implemente o método 
“CalcularValorTotal” em ambas as classes filhas, que recebe o número de diárias e 
retorna o valor calculado vezes a taxa do veículo.
B) Instancie um objeto de cada classe (Carro e Moto) e exiba o valor total para 10 
diarias usando o método “CalcularValorTotal”.
