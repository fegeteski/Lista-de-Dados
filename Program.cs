

// Exercicio para exibição ordenada em lista de dados recebidos.


var dados_recebidos = ("2020-12-10 03:00:00,-25.1925,-42.5263,12.7,22.0,0.45,1.34,143,24.6,21.2,80.4," +
    "1013.5,0.0,25.0,46.3,202.0,46.3,202.0,46.3,202.0,1.38,6.9,2.27,13.0,62.0,1.32,7.1,46.0").Split(',');

var txt_dados = ("Data e Hora:,Latitude:,Longitude:,Voltagem:,DataLogger:," +"Velocidade Media do Vento 1:," +
"Rajada 1:,Direção do Vento 1:,Velocidade Media do Vento 2:,Rajada 2:,Direção do Vento 2:," +
"Temperatura do Ar:,Umidade Relatica,Ponto de Orvalho:," +"Pressão Atmosferica:,Temperatura Sup Mar:," +
"Bússola:,Radiação Solar Média").Split(',');


string[] txt = txt_dados;
string[] informacoes = dados_recebidos; 

Console.WriteLine("Dados Da Boia 1" + "\r\n");

Console.WriteLine(txt_dados[0] + " " + dados_recebidos[0] + "\r\n" + txt_dados[1] + " " + dados_recebidos[1] + 
"\r\n" + txt_dados[2] + " " + dados_recebidos[2] + "\r\n" + txt_dados[3] + " " + dados_recebidos[3] + 
"\r\n" + txt_dados[4] + " " + dados_recebidos[4] + "\r\n" + txt_dados[5] + " " + dados_recebidos[5] + 
"\r\n" + txt_dados[6] + " " + dados_recebidos[6] + "\r\n" + txt_dados[7] + " " + dados_recebidos[7] +
"\r\n" + txt_dados[8] + " " + dados_recebidos[8] + "\r\n" + txt_dados[9] + " " + dados_recebidos[9] + 
"\r\n" + txt_dados[10] + " " + dados_recebidos[10] + "\r\n" + txt_dados[11] + " " + dados_recebidos[11] + 
"\r\n" + txt_dados[12] + " " + dados_recebidos[12] + "\r\n" + txt_dados[13] + " " + dados_recebidos[13] + 
"\r\n" + txt_dados[14] + " " + dados_recebidos[14] + "\r\n" + txt_dados[15] + " " + dados_recebidos[15] + 
"\r\n" + txt_dados[16] + " " + dados_recebidos[16] + "\r\n" + txt_dados[17] + " " + dados_recebidos[17]);