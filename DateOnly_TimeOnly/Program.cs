Console.WriteLine("*** Testes com DateOnly ***");

var diaDasMaes = new DateOnly(2021, 05, 08);
Console.WriteLine($"Ignite 2021 = {diaDasMaes}");

var diaDosPais = new DateOnly(2021, 08, 15);
Console.WriteLine($"Build 2021 = {diaDosPais}");

var diaDasCriancas = new DateOnly(2021, 10, 12);
Console.WriteLine($".NET Conf 2021 = {diaDasCriancas}");

if (diaDosPais > diaDasMaes && diaDosPais < diaDasCriancas)
    Console.WriteLine("O dia dos pais acontece depois do dia das maes e antes do dia das criancas!");

Console.WriteLine();
Console.WriteLine("*** Testes com TimeOnly ***");

var inicioDiaTrabalho = new TimeOnly(09, 00);
Console.WriteLine($"Início do dia de trabalho = {inicioDiaTrabalho}");

var terminoDiaTrabalho = new TimeOnly(18, 30);
Console.WriteLine($"Término do dia de trabalho = {terminoDiaTrabalho}");

var reuniaoTop = new TimeOnly(10, 30);
Console.WriteLine($"Horário daquela reuniao Top = {reuniaoTop}");

if (reuniaoTop > inicioDiaTrabalho && reuniaoTop < terminoDiaTrabalho)
    Console.WriteLine("A reuniao Top começa no meio do horário de trabalho!");