using Aula01._1bim;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

int opcao = 0;
bool continuar = true;
while (continuar)
{
    Console.WriteLine("=== MENU PRINCIPAL ===");
    Console.WriteLine("1 - Somar Dois Números");
    Console.WriteLine("2 - Converter Metros para Milímetros");
    Console.WriteLine("3 - Calcular Aumento Salarial");
    Console.WriteLine("4 - Calcular Desconto de Mercadoria");
    Console.WriteLine("5 - Calcular Aluguel de Carro");
    Console.WriteLine("6 - Calcular IMC");
    Console.WriteLine("7 - Tabuada de cada número");
    Console.WriteLine("8 - Múltiplos de 3 entre 0 e 10");
    Console.WriteLine("9 - Fatoriais de 1 até 10");
    Console.WriteLine("10 - Imposto de renda");
    Console.WriteLine("11 - Adivinhar número");
    Console.WriteLine("12 - Financiamento de veículo");
    Console.WriteLine("13 - Aposentadoria");
    Console.WriteLine("14 - Sair");
    Console.WriteLine("Informe a opção desejada: ");
    
    try{
    opcao = int.Parse(Console.ReadLine());
    }
    catch{
        Console.WriteLine("Opção inválida!");
        continue;
    }
    
    switch (opcao)
    {
        case 1:
            Soma();
            break;
        case 2:
            Conversor();
            break;
        case 3:
            Aumento();
            break;
        case 4: 
            Desconto();
            break;
        case 5: 
            Aluguel();
            break;
        case 6:
            IMC();
            break;
        case 7:
            Tabuada();
            break;
        case 8:
            Multiplo();
            break;
        case 9:
            Fatorial();
            break;
        case 10: 
            Imposto();
            break;
        case 11: 
            Adivinhar();
            break;
        case 12:
            Financiamento();
            break;
        case 13:
            Aposentadoria();
            break;
        case 14:
            continuar = false;
            break;
    }

}
void Soma()
{
    try{
    int num1, num2;
    Console.WriteLine("Informe o primeiro número");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo número");
    num2 = int.Parse(Console.ReadLine());
    somadoisnumeros somador = new somadoisnumeros();
    int resultado = somador.Somar(num1, num2);
    Console.WriteLine($"A soma dos números {num1} e {num2} é {resultado}");
    }
    catch {
        Console.WriteLine("Entrada inválida!");
    }
}
void Conversor()
{
    try{
    MetrosMilimetros metrosMilimetros = new MetrosMilimetros();
    Console.WriteLine("Informe o valor em metros: ");
    int metros = int.Parse(Console.ReadLine());
        Console.WriteLine($"O valor {metros}m corresponde a {metrosMilimetros.Multiplicar(metros)} milímetros ");
    }
   catch {
        Console.WriteLine("Entrada inválida!");
    }
}
void Aumento()
{
    try{
    CalculaAumento calculaAumento = new CalculaAumento();
    Console.Write("Digite o salário atual (em reais): ");
    int salario = int.Parse(Console.ReadLine());
    Console.Write("Digite o percentual de aumento (%): ");
    int percentual = int.Parse(Console.ReadLine());
    int aumento = calculaAumento.CalcularAumento(salario, percentual);
    int novoSalario = calculaAumento.NovoSalario(salario, aumento);
    Console.WriteLine($"\nSalário inicial: R$ {salario},00");
    Console.WriteLine($"Percentual de aumento: {percentual}%");
    Console.WriteLine($"Valor do aumento: R$ {aumento},00");
    Console.WriteLine($"Novo salário: R$ {novoSalario},00");
    }
    catch
    {
        Console.WriteLine("Entrada inválida!");
    }
}
void Desconto()
{
    try{
    CalculaDesconto calculaDesconto = new CalculaDesconto();
    Console.Write("Digite o valor atual da mercadoria (em reais): ");
    float valorAtual = float.Parse(Console.ReadLine());
    Console.Write("Digite o percentual de desconto (%): ");
    float percentual = float.Parse(Console.ReadLine());
    float desconto = calculaDesconto.CalcularDesconto(valorAtual, percentual);
    float valorFinal = calculaDesconto.CalcularValorFinal(valorAtual, desconto);
    Console.WriteLine($"\nValor atual: R$ {valorAtual}");
    Console.WriteLine($"Percentual de desconto: {percentual}%");
    Console.WriteLine($"Valor do desconto: R$ {desconto}");
    Console.WriteLine($"Valor final da mercadoria: R$ {valorFinal}");
    }
    catch {
        Console.WriteLine("Entrada inválida!");
    }
}
void Aluguel()
{
    try{
    AluguelCarro carro = new AluguelCarro();
    Console.WriteLine("Quantos dias o carro foi alugado? ");
    int dias = int.Parse(Console.ReadLine());
    Console.WriteLine("Qual era a quilometragem inicial? ");
    int kmInicial = int.Parse(Console.ReadLine());
    Console.WriteLine("Qual é a quilometragem final? ");
    int kmFinal = int.Parse(Console.ReadLine());

    int kmPercorridos = kmFinal - kmInicial;
    int custoDiaria = carro.CalcularCustoDiaria(dias);
    double custoKm = carro.CalcularCustoKm(kmPercorridos);
    double total = carro.CalcularTotal(custoDiaria, custoKm);

    Console.WriteLine($"\nDias alugados: {dias}");
    Console.WriteLine($"Quilometragem percorrida: {kmPercorridos} km");
    Console.WriteLine($"Custo das diárias: R${custoDiaria}");
    Console.WriteLine($"Custo por km rodado: R${custoKm:F2}");
    Console.WriteLine($"Total a pagar: R${total:F2}\n"); 
    }
    catch {
        Console.WriteLine("Entrada inválida!");
    }
}
void IMC()
{
    try{
        Console.Write("Digite seu peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite sua altura (m): ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Digite seu gênero (M/F): ");
        string genero = Console.ReadLine().ToUpper();

        CalculadoraIMC calc = new CalculadoraIMC();
        double imc = calc.Calcular(peso, altura);
        string classificacao = calc.Classificar(imc);

        Console.WriteLine($"\nSeu IMC é: {imc:F2}");
        Console.WriteLine($"Classificação: {classificacao}\n");
    }
    catch
    {
        Console.WriteLine("Entrada inválida.\n");
    } 
}

void Tabuada()
{
    try{
        Console.Write("Digite um número para gerar a tabuada: ");
        int numero = int.Parse(Console.ReadLine());
        Tabuada tabuada = new Tabuada();
        string resultado = tabuada.Gerar(numero);
        Console.WriteLine($"\nTabuada de {numero}:\n{resultado}");
    }
    catch{
      Console.WriteLine("Entrada inválida!");
    }  
}

void Multiplo()
{
    try{
        MultiplosDe3 multiplo = new MultiplosDe3();
        string resultado = multiplo.Listar();
        Console.WriteLine("\nMúltiplos de 3 entre 0 e 100:\n" + resultado);
        }
    catch{
      Console.WriteLine("Entrada inválida!");
    }  
}

void Fatorial()
{
    try{
        Fatorial fatorial = new Fatorial();
        string resultado = fatorial.Calcular();
        Console.WriteLine("\nFatoriais de 1 a 10:\n" + resultado);
        }
    catch{
      Console.WriteLine("Entrada inválida!");
    }  
}

void Imposto()
{
    try{
        Console.Write("Digite sua renda mensal (em reais): ");
        double salario = double.Parse(Console.ReadLine());

        Console.Write("Digite o número de dependentes: ");
        int dependentes = int.Parse(Console.ReadLine());

        CalculoImposto calculadora = new CalculoImposto();
        double imposto = calculadora.Calcular(salario, dependentes);

        Console.WriteLine($"O valor do imposto devido é: R${imposto:F2}\n");
    }
    catch{
      Console.WriteLine("Entrada inválida!");
    }  
}
void Adivinhar()
{
    AdivinharNumero jogo = new AdivinharNumero();
    int tentativas = 10;
    bool acertou = false;

    Console.WriteLine("\nVocê tem 10 chances para adivinhar o número entre 0 e 100.");

    for (int i = 1; i <= tentativas; i++)
    {
        try
        {
            Console.Write($"Tentativa {i}: Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (jogo.Acertou(numero))
            {
                Console.WriteLine("Parabéns! Você acertou o número.\n");
                acertou = true;
                break;
            }
            else
            {
                Console.WriteLine(jogo.VerificarTentativa(numero));
            }
        }
        catch
        {
            Console.WriteLine("Entrada inválida. Digite um número válido.");
            i--; 
        }
    }

    if (!acertou)
    {
        Console.WriteLine("Você não acertou o número. Fim de jogo.\n");
    }
} 

void Financiamento()
{
    try{
        Console.Write("Informe o valor do veículo (em R$): ");
        double valorVeiculo = double.Parse(Console.ReadLine());

        Console.Write("Informe o número total de parcelas: ");
        int parcelas = int.Parse(Console.ReadLine());

        Console.Write("Informe a taxa mensal de juros (%), ou 0 para taxa zero: ");
        double taxaMensal = double.Parse(Console.ReadLine());

        taxaMensal /= 100; 

        FinanciamentoVeiculo financiamento = new FinanciamentoVeiculo();
        double parcela = financiamento.CalcularParcela(valorVeiculo, parcelas, taxaMensal);
        double totalPago = financiamento.CalcularTotalPago(parcela, parcelas);

        Console.WriteLine($"\nValor da parcela: R${parcela:F2}");
        Console.WriteLine($"Total pago após {parcelas} parcelas: R${totalPago:F2}\n");
    }
    catch{
      Console.WriteLine("Entrada inválida!");
    }  
}
void Aposentadoria()
{
    try{
        Console.Write("Informe sua idade atual: ");
                int idadeAtual = int.Parse(Console.ReadLine());

                Console.Write("Com quantos anos pretende se aposentar? ");
                int idadeAposentadoria = int.Parse(Console.ReadLine());

                Console.Write("Quanto pretende guardar por mês (em R$)? ");
                double valorMensal = double.Parse(Console.ReadLine());

                Console.Write("Informe a taxa de rendimento mensal (%): ");
                double taxaMensal = double.Parse(Console.ReadLine()) / 100;

                int anosParaAposentar = idadeAposentadoria - idadeAtual;

                if (anosParaAposentar <= 0)
                {
                    Console.WriteLine("Você já tem a idade para aposentadoria.\n");
                    return;
                }

                Aposentadoria calc = new Aposentadoria();
                double montante = calc.CalcularMontante(anosParaAposentar, valorMensal, taxaMensal);
                double rendaMensal = calc.CalcularRendaMensal(montante, taxaMensal);

                Console.WriteLine($"\nAnos até a aposentadoria: {anosParaAposentar}");
                Console.WriteLine($"Montante acumulado: R${montante:F2}");
                Console.WriteLine($"Renda mensal após aposentadoria: R${rendaMensal:F2}\n");
}
catch{
      Console.WriteLine("Entrada inválida!");
    }  
}
