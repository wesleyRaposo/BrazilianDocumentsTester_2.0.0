using System;
using BrazilianDocuments.Validators;
using DocumentosBrasileirosX.Validadores;

namespace BrazilianDocumentsTester
{

    // *** Ao reinstalar pacotes, limpe o "lixo" na pasta "C:\Users\wesle\.nuget\packages\braziliandocuments"
    // *** Ao reinstalar pacotes, limpe o "lixo" na pasta "C:\Users\wesle\.nuget\packages\documentosbrasileiros"

    // CNPJs ALFANUMÉRICOs PARA TESTE: 12ABC34501DE35    ABCDEFGIHIJK56

    class Program
    {
        static ConsoleColor corDeFundo = ConsoleColor.Black;
        
        static ConsoleColor corDeTitulo = ConsoleColor.DarkRed;
        static ConsoleColor corDeTituloDestacado = ConsoleColor.Yellow;

        static ConsoleColor corDeTituloPrincipal = ConsoleColor.DarkRed;
        static ConsoleColor corDeTituloDestacadoPrincipal = ConsoleColor.Yellow;

        static ConsoleColor corDeTituloBrazilianDocuments = ConsoleColor.DarkBlue;
        static ConsoleColor corDeTituloDestacadoBrazilianDocuments = ConsoleColor.Cyan;

        static ConsoleColor corDeTituloDocumentosBrasileiros = ConsoleColor.Cyan;
        static ConsoleColor corDeTituloDestacadoDocumentosBrasileiros = ConsoleColor.DarkBlue;

        static ConsoleColor corDeNumero = ConsoleColor.Yellow;
        static ConsoleColor corDeTextoDefault = ConsoleColor.White;
        static ConsoleColor corDeSaida = ConsoleColor.Red;
        static ConsoleColor corDoLogo = ConsoleColor.Cyan;

        static void Main(string[] args)
        {
            CarregaOpcaoDePacote();
        }

        private static void CarregaOpcaoDePacote()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTituloPrincipal;
            Console.ForegroundColor = corDeTituloDestacadoPrincipal;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                SELECIONE O PACOTE A SER VALIDADO  /  SELECT THE PACKAGE TO BE VALIDATED                  ||");
            Console.WriteLine("+============================================================================================================+");
            Console.ForegroundColor = corDeTextoDefault;
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.WriteLine($"{PintaOpcaoEmDestaque(" 1)")} Testar pacote \"BrazilianDocuments\"               /   Test \"BrazilianDocuments\" package                 \u001b[44;37;01m\"\u001b[41;37;01m==\u001b[00m  ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 2)")} Testar pacote \"DocumentosBrasileiros\"            /   Test \"DocumentosBrasileiros\" package              \u001b[42;33;01m<\u001b[34mO\u001b[33m>\u001b[00m  ");

            Console.WriteLine("");
            Console.ForegroundColor = corDeSaida;
            Console.WriteLine(" Qualquer outra tecla para sair                      /   Any other key to exit ");
            Console.ForegroundColor = corDeTextoDefault;
            ConsoleKeyInfo tecla = Console.ReadKey();

            switch (Char.ToUpper(tecla.KeyChar))
            {
                case '1':
                    Console.Clear();
                    Console.Beep();
                    CarregarValidacaodoBrazilianDocuments();
                    break;
                case '2':
                    Console.Clear();
                    Console.Beep();
                    CarregarValidacaodoDocumentosBrasileiros();
                    break;
                default:
                    Console.Clear();
                    Console.Beep();
                    ExibirLogo();
                    Console.WriteLine("");
                    Console.ForegroundColor = corDeSaida;
                    Console.WriteLine("                                       Obrigado  / Thank you");
                    Console.ForegroundColor = corDeTextoDefault;
                    Console.WriteLine("");
                    break;
            }

        }

        private static void CarregarValidacaodoBrazilianDocuments()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTituloBrazilianDocuments;
            Console.ForegroundColor = corDeTituloDestacadoBrazilianDocuments;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                          Pacote BrazilianDocuments  /  BrazilianDocuments Package                        ||");
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                    SELECIONE A ROTINA DE VALIDAÇÃO  /  SELECT THE VALIDATION ROUTINE                     ||");
            Console.WriteLine("+============================================================================================================+");
            Console.ForegroundColor = corDeTextoDefault;
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.WriteLine($"{PintaOpcaoEmDestaque(" 1)")} Testar validação de CPF                            /   Test \"CPF\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 2)")} Testar validação de Título de Eleitor              /   Test \"Voter card\" Validation ");

            Console.WriteLine($"{PintaOpcaoEmDestaque(" 3)")} Testar validação de CNPJ                           /   Test \"CNPJ\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 4)")} Testar validação de PIS/PASEP                      /   Test \"PIS/PASEP\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 5)")} Testar validação de Inscrição Estadual             /   Test \"State Registration\" Validation ");

            Console.WriteLine($"{PintaOpcaoEmDestaque(" 6)")} Testar validação de CNH                            /   Test \"driver's License\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 7)")} Testar validação de RENAVAM                        /   Test \"RENAVAM\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 8)")} Testar validação de placa veicular                 /   Test \"license plate\" validation ");
            
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 9)")} Testar validação de passaporte                     /   Test \"passport\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 0)")} Testar validação de CEP                            /   Test \"zip code\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" A)")} Testar certidões (nascimento, casamento e óbito)   /   Test \"certificate\" validation (birth, marriage and death) ");

            Console.WriteLine("");
            Console.ForegroundColor = corDeSaida;
            Console.WriteLine(" Qualquer outra tecla para voltar                        /   Any other key to go back ");
            Console.ForegroundColor = corDeTextoDefault;
            ConsoleKeyInfo tecla = Console.ReadKey();

            switch (Char.ToUpper(tecla.KeyChar))
            {
                case '1':
                    Console.Clear();
                    Console.Beep();
                    TestarValidacaoDeCpfBrazilianDocuments();
                    Console.ReadKey();
                    CarregarValidacaodoBrazilianDocuments();
                    break;
                case '2':
                    Console.Clear();
                    TestarValidacaoTituloDeEleitorBrazilianDocuments();
                    Console.ReadKey();
                    CarregarValidacaodoBrazilianDocuments();
                    break;
                case '3':
                    Console.Clear();
                    TestarValidacaoDeCnpjBrazilianDocuments();
                    Console.ReadKey();
                    CarregarValidacaodoBrazilianDocuments();
                    break;
                case '4':
                    Console.Clear();
                    TestarValidacaoPisPasepBrazilianDocuments();
                    Console.ReadKey();
                    CarregarValidacaodoBrazilianDocuments();
                    break;
                case '5':
                    Console.Clear();
                    TestarInscricaoEstadualBrazilianDocuments();
                    Console.ReadKey();
                    CarregarValidacaodoBrazilianDocuments();
                    break;
                case '6':
                    Console.Clear();
                    TestarValidacaoCnhBrazilianDocuments();
                    Console.ReadKey();
                    CarregarValidacaodoBrazilianDocuments();
                    break;
                case '7':
                    Console.Clear();
                    TestarValidacaoRenavamBrazilianDocuments();
                    Console.ReadKey();
                    CarregarValidacaodoBrazilianDocuments();
                    break;
                case '8':
                    Console.Clear();
                    TestarValidacaoPlacaVeicularBrazilianDocuments();
                    Console.ReadKey();
                    CarregarValidacaodoBrazilianDocuments();
                    break;
                case '9':
                    Console.Clear();
                    TestarValidacaoPassaporteBrazilianDocuments();
                    Console.ReadKey();
                    CarregarValidacaodoBrazilianDocuments();
                    break;
                case '0':
                    Console.Clear();
                    TestarValidacaoCepBrazilianDocuments();
                    Console.ReadKey();
                    CarregarValidacaodoBrazilianDocuments();
                    break;
                case ('A'):
                    Console.Clear();
                    TestarValidacaoCertidaoBrazilianDocuments();
                    Console.ReadKey();
                    CarregarValidacaodoBrazilianDocuments();
                    break;
                default:
                    Console.Clear();
                    CarregaOpcaoDePacote();
                    break;
            }
        }

        private static void CarregarValidacaodoDocumentosBrasileiros()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTituloDocumentosBrasileiros;
            Console.ForegroundColor = corDeTituloDestacadoDocumentosBrasileiros;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                       Pacote DocumentosBrasileirosX  /  DocumentosBrasileirosX Package                   ||");
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                    SELECIONE A ROTINA DE VALIDAÇÃO  /  SELECT THE VALIDATION ROUTINE                     ||");
            Console.WriteLine("+============================================================================================================+");
            Console.ForegroundColor = corDeTextoDefault;
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.WriteLine($"{PintaOpcaoEmDestaque(" 1)")} Testar validação de CPF                            /   Test \"CPF\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 2)")} Testar validação de Título de Eleitor              /   Test \"Voter card\" Validation ");

            Console.WriteLine($"{PintaOpcaoEmDestaque(" 3)")} Testar validação de CNPJ                           /   Test \"CNPJ\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 4)")} Testar validação de PIS/PASEP                      /   Test \"PIS/PASEP\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 5)")} Testar validação de Inscrição Estadual             /   Test \"State Registration\" Validation ");

            Console.WriteLine($"{PintaOpcaoEmDestaque(" 6)")} Testar validação de CNH                            /   Test \"driver's License\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 7)")} Testar validação de RENAVAM                        /   Test \"RENAVAM\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 8)")} Testar validação de placa veicular                 /   Test \"license plate\" validation ");

            Console.WriteLine($"{PintaOpcaoEmDestaque(" 9)")} Testar validação de passaporte                     /   Test \"passport\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" 0)")} Testar validação de CEP                            /   Test \"zip code\" validation ");
            Console.WriteLine($"{PintaOpcaoEmDestaque(" A)")} Testar certidões (nascimento, casamento e óbito)   /   Test \"certificate\" validation (birth, marriage and death) ");

            Console.WriteLine("");
            Console.ForegroundColor = corDeSaida;
            Console.WriteLine(" Qualquer outra tecla para voltar                        /   Any other key to go back ");
            Console.ForegroundColor = corDeTextoDefault;
            ConsoleKeyInfo tecla = Console.ReadKey();

            switch (Char.ToUpper(tecla.KeyChar))
            {
                case '1':
                    Console.Clear();
                    Console.Beep();
                    TestarValidacaoDeCpfDocumentosBrasileiros();
                    Console.ReadKey();
                    CarregarValidacaodoDocumentosBrasileiros();
                    break;
                case '2':
                    Console.Clear();
                    TestarValidacaoTituloDeEleitorDocumentosBrasileiros();
                    Console.ReadKey();
                    CarregarValidacaodoDocumentosBrasileiros();
                    break;
                case '3':
                    Console.Clear();
                    TestarValidacaoDeCnpjDocumentosBrasileiros();
                    Console.ReadKey();
                    CarregarValidacaodoDocumentosBrasileiros();
                    break;
                case '4':
                    Console.Clear();
                    TestarValidacaoPisPasepDocumentosBrasileiros();
                    Console.ReadKey();
                    CarregarValidacaodoDocumentosBrasileiros();
                    break;
                case '5':
                    Console.Clear();
                    TestarInscricaoEstadualDocumentosBrasileiros();
                    Console.ReadKey();
                    CarregarValidacaodoDocumentosBrasileiros();
                    break;
                case '6':
                    Console.Clear();
                    TestarValidacaoCnhDocumentosBrasileiros();
                    Console.ReadKey();
                    CarregarValidacaodoDocumentosBrasileiros();
                    break;
                case '7':
                    Console.Clear();
                    TestarValidacaoRenavamDocumentosBrasileiros();
                    Console.ReadKey();
                    CarregarValidacaodoDocumentosBrasileiros();
                    break;
                case '8':
                    Console.Clear();
                    TestarValidacaoPlacaVeicularDocumentosBrasileiros();
                    Console.ReadKey();
                    CarregarValidacaodoDocumentosBrasileiros();
                    break;
                case '9':
                    Console.Clear();
                    TestarValidacaoPassaporteDocumentosBrasileiros();
                    Console.ReadKey();
                    CarregarValidacaodoDocumentosBrasileiros();
                    break;
                case '0':
                    Console.Clear();
                    TestarValidacaoCepDocumentosBrasileiros();
                    Console.ReadKey();
                    CarregarValidacaodoDocumentosBrasileiros();
                    break;
                case ('A'):
                    Console.Clear();
                    TestarValidacaoCertidaoDocumentosBrasileiros();
                    Console.ReadKey();
                    CarregarValidacaodoDocumentosBrasileiros();
                    break;
                default:
                    Console.Clear();
                    CarregaOpcaoDePacote();
                    break;
            }
        }

        private static string PintaOpcaoEmDestaque(string texto)
        {
            Console.ForegroundColor = corDeNumero;
            Console.Write(texto);
            Console.ForegroundColor = corDeTextoDefault;
            return "";
        }

        private static void TestarValidacaoCertidaoBrazilianDocuments()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("|| Teste de certidões (nascimento, casamento e óbito) / \"Certificate\" validation (birth, marriage & death)  ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Digite um número de certidão / Enter a \"Certificate\" number: ");
            Console.BackgroundColor = ConsoleColor.Blue;
            string certidao = Console.ReadLine();
            Console.WriteLine("");
            
            Console.BackgroundColor = corDeFundo;
            Console.Write("ClearCode: ");
            certidao = CertidaoRegistroCivilValidator.ClearCode(certidao);
            Console.Write(PintaOpcaoEmDestaque(certidao));
            Console.WriteLine("");

            Console.Write("IsValid: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidator.IsValid(certidao).ToString()));
            Console.WriteLine("");

            Console.Write("GetLastValidationCode: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidator.GetLastValidationCode()));
            Console.WriteLine("");

            Console.Write("GetLastValidationMessage: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidator.GetLastValidationMessage()));
            Console.WriteLine("");

            Console.Write("ValidateReturningMessage: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidator.ValidateReturningMessage(certidao)));
            Console.WriteLine("");

            Console.Write("Format: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidator.Format(certidao)));
            Console.WriteLine("");

            Console.Write("DecodeCertificate (método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidator.DecodeCertificateinJson(certidao)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Help: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidator.Help()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Author: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidator.Author()));
            /**/
        }

        private static void TestarInscricaoEstadualBrazilianDocuments()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||              Teste do validador de Inscrição Estadual / \"State Registration\" validator test              ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");


            Console.Write("Digite um Inscrição Estadual / Enter a State Registration number: ");
            Console.BackgroundColor = ConsoleColor.Blue;
            string inscricaoEstadual = Console.ReadLine();
            Console.WriteLine("");

            Console.BackgroundColor = corDeFundo;
            Console.Write("Digite a UF da inscrição estadual / Enter the state abbreviation of the state registration: ");
            Console.BackgroundColor = ConsoleColor.Blue;
            string ufString = Console.ReadLine();
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            BrazilianDocuments.Validators.UnidadeDaFederacao uf = ConverteUfStringParaUf_BrazilianDocuments(ufString);

            Console.Write("ClearCode: ");
            inscricaoEstadual = InscricaoEstadualValidator.ClearCode(inscricaoEstadual);
            Console.Write(PintaOpcaoEmDestaque(inscricaoEstadual));
            Console.WriteLine("");

            Console.Write("IsValid: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidator.IsValid(inscricaoEstadual, uf).ToString()));
            Console.WriteLine("");

            Console.Write("GetLastValidationCode: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidator.GetLastValidationCode()));
            Console.WriteLine("");

            Console.Write("GetLastValidationMessage: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidator.GetLastValidationMessage()));
            Console.WriteLine("");

            Console.Write("ValidateReturningMessage: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidator.ValidateReturningMessage(inscricaoEstadual, uf)));
            Console.WriteLine("");

            Console.Write("Format: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidator.Format(inscricaoEstadual, uf)));
            Console.WriteLine("");

            Console.Write("GetUFName (método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidator.GetUFName(uf)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Help: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidator.Help()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Author: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidator.Author()));
        }

        private static BrazilianDocuments.Validators.UnidadeDaFederacao ConverteUfStringParaUf_BrazilianDocuments(string ufString)
        {
            switch (ufString.ToUpper())
            {
                case "AC":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.AC;
                case "AL":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.AL;
                case "AM":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.AM;
                case "AP":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.AP;
                case "BA":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.BA;
                case "CE":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.CE;
                case "DF":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.DF;
                case "ES":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.ES;
                case "GO":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.GO;
                case "MA":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.MA;
                case "MT":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.MT;
                case "MS":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.MS;
                case "MG":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.MG;
                case "PA":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.PA;
                case "PB":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.PB;
                case "PE":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.PE;
                case "PI":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.PI;
                case "PR":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.PR;
                case "RJ":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.RJ;
                case "RN":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.RN;
                case "RO":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.RO;
                case "RR":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.RR;
                case "RS":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.RS;
                case "SC":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.SC;
                case "SE":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.SE;
                case "SP":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.SP;
                case "TO":
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.TO;
                default:
                    return BrazilianDocuments.Validators.UnidadeDaFederacao.TO;
            }
        }

        private static DocumentosBrasileirosX.Validadores.UnidadeDaFederacao ConverteUfStringParaUf_DocumentosBrasileiros(string ufString)
        {
            switch (ufString.ToUpper())
            {
                case "AC":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.AC;
                case "AL":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.AL;
                case "AM":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.AM;
                case "AP":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.AP;
                case "BA":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.BA;
                case "CE":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.CE;
                case "DF":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.DF;
                case "ES":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.ES;
                case "GO":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.GO;
                case "MA":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.MA;
                case "MT":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.MT;
                case "MS":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.MS;
                case "MG":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.MG;
                case "PA":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.PA;
                case "PB":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.PB;
                case "PE":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.PE;
                case "PI":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.PI;
                case "PR":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.PR;
                case "RJ":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.RJ;
                case "RN":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.RN;
                case "RO":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.RO;
                case "RR":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.RR;
                case "RS":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.RS;
                case "SC":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.SC;
                case "SE":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.SE;
                case "SP":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.SP;
                case "TO":
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.TO;
                default:
                    return DocumentosBrasileirosX.Validadores.UnidadeDaFederacao.TO;
            }
        }


        private static void TestarValidacaoCepBrazilianDocuments()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                         Teste do validador de CEP / \"Zip code\" validator test                            ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Digite um CEP / Enter a Zip code number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string cep = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("ClearCode: ");
            cep = CepValidator.ClearCode(cep);
            Console.Write(PintaOpcaoEmDestaque(cep));
            Console.WriteLine("");

            Console.Write("IsValid: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidator.IsValid(cep).ToString()));
            Console.WriteLine("");

            Console.Write("GetLastValidationCode: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidator.GetLastValidationCode()));
            Console.WriteLine("");

            Console.Write("GetLastValidationMessage: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidator.GetLastValidationMessage()));
            Console.WriteLine("");

            Console.Write("ValidateReturningMessage: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidator.ValidateReturningMessage(cep)));
            Console.WriteLine("");

            Console.Write("Format: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidator.Format(cep)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("CepExists (método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(CepValidator.CepExists(cep).ToString()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("GetCepAddressInJson (método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(CepValidator.GetCepAddressInJson(cep)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Help: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidator.Help()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Author: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidator.Author()));
        }

        private static void TestarValidacaoPlacaVeicularBrazilianDocuments()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                    Teste do validador de placa veicular / \"Licence plate\" validator test                 ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");


            Console.Write("Digite um placa veicular / Enter a licence plate number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string placaVeicular = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("ClearCode: ");
            placaVeicular = PlacaVeicularValidator.ClearCode(placaVeicular);
            Console.Write(PintaOpcaoEmDestaque(placaVeicular));
            Console.WriteLine("");

            Console.Write("IsValid: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidator.IsValid(placaVeicular).ToString()));
            Console.WriteLine("");

            Console.Write("GetLastValidationCode: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidator.GetLastValidationCode()));
            Console.WriteLine("");

            Console.Write("GetLastValidationMessage: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidator.GetLastValidationMessage()));
            Console.WriteLine("");

            Console.Write("ValidateReturningMessage: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidator.ValidateReturningMessage(placaVeicular)));
            Console.WriteLine("");

            Console.Write("Format: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidator.Format(placaVeicular)));
            Console.WriteLine("");

            Console.Write("IdentifiesFederativeUnitoftheGrayPlate (método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidator.IdentifiesFederativeUnitoftheGrayPlate(placaVeicular)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Help: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidator.Help()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Author: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidator.Author()));
        }

        private static void TestarValidacaoCnhBrazilianDocuments()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                     Teste do validador de CNH / \"Driver's License\" validator test                        ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Digite um CNH / Enter a Driver's License number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string cnh = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("ClearCode: ");
            cnh = CnhValidator.ClearCode(cnh);
            Console.Write(PintaOpcaoEmDestaque(cnh));
            Console.WriteLine("");

            Console.Write("IsValid: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidator.IsValid(cnh).ToString()));
            Console.WriteLine("");

            Console.Write("GetLastValidationCode: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidator.GetLastValidationCode()));
            Console.WriteLine("");

            Console.Write("GetLastValidationMessage: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidator.GetLastValidationMessage()));
            Console.WriteLine("");

            Console.Write("ValidateReturningMessage: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidator.ValidateReturningMessage(cnh)));
            Console.WriteLine("");

            Console.Write("Format: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidator.Format(cnh)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Help: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidator.Help()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Author: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidator.Author()));
        }

        private static void TestarValidacaoPassaporteBrazilianDocuments()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                     Teste do validador de Passaporte / \"Passport\" validator test                         ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");


            Console.Write("Digite um Passaporte / Enter a Passport number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string passaporte = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("ClearCode: ");
            passaporte = PassaporteValidator.ClearCode(passaporte);
            Console.Write(PintaOpcaoEmDestaque(passaporte));
            Console.WriteLine("");

            Console.Write("IsValid: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidator.IsValid(passaporte).ToString()));
            Console.WriteLine("");

            Console.Write("GetLastValidationCode: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidator.GetLastValidationCode()));
            Console.WriteLine("");

            Console.Write("GetLastValidationMessage: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidator.GetLastValidationMessage()));
            Console.WriteLine("");

            Console.Write("ValidateReturningMessage: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidator.ValidateReturningMessage(passaporte)));
            Console.WriteLine("");

            Console.Write("Format: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidator.Format(passaporte)));
            Console.WriteLine("");

            Console.Write("Help: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidator.Help()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Author: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidator.Author()));
        }

        private static void TestarValidacaoRenavamBrazilianDocuments()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                        Teste do validador de RENAVAM / \"RENAVAM\" validator test                          ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Digite um RENAVAM / Enter a RENAVAM number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string renavam = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("ClearCode: ");
            renavam = RenavamValidator.ClearCode(renavam);
            Console.Write(PintaOpcaoEmDestaque(renavam));
            Console.WriteLine("");

            Console.Write("IsValid: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidator.IsValid(renavam).ToString()));
            Console.WriteLine("");

            Console.Write("GetLastValidationCode: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidator.GetLastValidationCode()));
            Console.WriteLine("");

            Console.Write("GetLastValidationMessage: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidator.GetLastValidationMessage()));
            Console.WriteLine("");

            Console.Write("ValidateReturningMessage: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidator.ValidateReturningMessage(renavam)));
            Console.WriteLine("");

            Console.Write("Format: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidator.Format(renavam)));
            Console.WriteLine("");

            Console.Write("Help: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidator.Help()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Author: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidator.Author()));
        }

        private static void TestarValidacaoTituloDeEleitorBrazilianDocuments()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                  Teste do validador de título de eleitor  / \"Voter card\" validator test                  ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");


            Console.Write("Digite um título de eleitor / Enter a voter card number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string titulo = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("ClearCode: ");
            titulo = TituloEleitoralValidator.ClearCode(titulo);
            Console.Write(PintaOpcaoEmDestaque(titulo));
            Console.WriteLine("");

            Console.Write("IsValid: ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidator.IsValid(titulo).ToString()));
            Console.WriteLine("");

            Console.Write("GetLastValidationCode: ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidator.GetLastValidationCode()));
            Console.WriteLine("");

            Console.Write("GetLastValidationMessage: ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidator.GetLastValidationMessage()));
            Console.WriteLine("");

            Console.Write("ValidateReturningMessage: ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidator.ValidateReturningMessage(titulo)));
            Console.WriteLine("");

            Console.Write("Format (default): ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidator.Format(titulo)));
            Console.WriteLine("");

            Console.Write("Format (enviando separadores / método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidator.Format(titulo, '-', '-')));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Help: ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidator.Help()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Author: ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidator.Author()));
        }

        private static void TestarValidacaoPisPasepBrazilianDocuments()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                      Teste do validador de PIS-PASEP  / \"PIS-PASEP\" validator test                       ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");


            Console.Write("Digite um PIS-PASEP / Enter a PIS-PASEP number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string pisPasep = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("ClearCode: ");
            pisPasep = PisPasepValidator.ClearCode(pisPasep);
            Console.Write(PintaOpcaoEmDestaque(pisPasep));
            Console.WriteLine("");

            Console.Write("IsValid: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidator.IsValid(pisPasep).ToString()));
            Console.WriteLine("");

            Console.Write("GetLastValidationCode: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidator.GetLastValidationCode()));
            Console.WriteLine("");

            Console.Write("GetLastValidationMessage: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidator.GetLastValidationMessage()));
            Console.WriteLine("");

            Console.Write("ValidateReturningMessage: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidator.ValidateReturningMessage(pisPasep)));
            Console.WriteLine("");

            Console.Write("Format: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidator.Format(pisPasep)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Help: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidator.Help()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Author: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidator.Author()));
        }

        private static void TestarValidacaoDeCnpjBrazilianDocuments()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                          Teste do validador de CNPJ  / \"CNPJ\" validator test                             ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");


            Console.Write("Digite um CNPJ / Enter a CNPJ number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string cnpj = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("ClearCode: ");
            cnpj = CnpjValidator.ClearCode(cnpj);
            Console.Write(PintaOpcaoEmDestaque(cnpj));
            Console.WriteLine("");

            Console.Write("IsValid: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidator.IsValid(cnpj).ToString()));
            Console.WriteLine("");

            Console.Write("GetLastValidationCode: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidator.GetLastValidationCode()));
            Console.WriteLine("");

            Console.Write("GetLastValidationMessage: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidator.GetLastValidationMessage()));
            Console.WriteLine("");

            Console.Write("ValidateReturningMessage: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidator.ValidateReturningMessage(cnpj)));
            Console.WriteLine("");

            Console.Write("Format: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidator.Format(cnpj)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Help: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidator.Help()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Author: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidator.Author()));
        }

        private static void TestarValidacaoDeCpfBrazilianDocuments()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                           Teste do validador de CPF  / \"CPF\" validator test                              ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Digite um CPF / Enter a CPF number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string cpf = Console.ReadLine();            

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("ClearCode: ");
            cpf = CpfValidator.ClearCode(cpf);
            Console.Write(PintaOpcaoEmDestaque(cpf));
            Console.WriteLine("");

            Console.Write("IsValid: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidator.IsValid(cpf).ToString()));
            Console.WriteLine("");

            Console.Write("GetLastValidationCode: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidator.GetLastValidationCode()));
            Console.WriteLine("");

            Console.Write("GetLastValidationMessage: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidator.GetLastValidationMessage()));
            Console.WriteLine("");

            Console.Write("ValidateReturningMessage: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidator.ValidateReturningMessage(cpf)));
            Console.WriteLine("");

            Console.Write("Format: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidator.Format(cpf)));
            Console.WriteLine("");

            Console.Write("ObtainCpfTaxRegion (método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidator.ObtainCpfTaxRegion(cpf)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Help: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidator.Help()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Author: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidator.Author()));
        }

        private static void TestarValidacaoCertidaoDocumentosBrasileiros()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("|| Teste de certidões (nascimento, casamento e óbito) / \"Certificate\" validation (birth, marriage & death)  ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Digite um número de certidão / Enter a \"Certificate\" number: ");
            Console.BackgroundColor = ConsoleColor.Blue;
            string certidao = Console.ReadLine();
            Console.WriteLine("");

            Console.BackgroundColor = corDeFundo;
            Console.Write("Limpar: ");
            certidao = CertidaoRegistroCivilValidador.Limpar(certidao);
            Console.Write(PintaOpcaoEmDestaque(certidao));
            Console.WriteLine("");

            Console.Write("Validar: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidador.Validar(certidao).ToString()));
            Console.WriteLine("");

            Console.Write("ObterUltimoCodigoDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidador.ObterUltimoCodigoDeValidacao()));
            Console.WriteLine("");

            Console.Write("ObterUltimaMensagemDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidador.ObterUltimaMensagemDeValidacao()));
            Console.WriteLine("");

            Console.Write("ValidarRetornandoMensagem: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidador.ValidarRetornandoMensagem(certidao)));
            Console.WriteLine("");

            Console.Write("Formatar: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidador.Formatar(certidao)));
            Console.WriteLine("");

            Console.Write("DecodificaCertidaoemJson (método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidador.DecodificaCertidaoemJson(certidao)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Ajuda: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidador.Ajuda()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Autor: ");
            Console.Write(PintaOpcaoEmDestaque(CertidaoRegistroCivilValidador.Autor()));
        }

        private static void TestarInscricaoEstadualDocumentosBrasileiros()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||              Teste do validador de Inscrição Estadual / \"State Registration\" validator test              ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");


            Console.Write("Digite um Inscrição Estadual / Enter a State Registration number: ");
            Console.BackgroundColor = ConsoleColor.Blue;
            string inscricaoEstadual = Console.ReadLine();
            Console.WriteLine("");

            Console.BackgroundColor = corDeFundo;
            Console.Write("Digite a UF da inscrição estadual / Enter the state abbreviation of the state registration: ");
            Console.BackgroundColor = ConsoleColor.Blue;
            string ufString = Console.ReadLine();
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            DocumentosBrasileirosX.Validadores.UnidadeDaFederacao uf = ConverteUfStringParaUf_DocumentosBrasileiros(ufString);

            Console.Write("Limpar: ");
            inscricaoEstadual = InscricaoEstadualValidador.Limpar(inscricaoEstadual);
            Console.Write(PintaOpcaoEmDestaque(inscricaoEstadual));
            Console.WriteLine("");

            Console.Write("Validar: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidador.Validar(inscricaoEstadual, uf).ToString()));
            Console.WriteLine("");

            Console.Write("ObterUltimoCodigoDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidador.ObterUltimoCodigoDeValidacao()));
            Console.WriteLine("");

            Console.Write("ObterUltimaMensagemDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidador.ObterUltimaMensagemDeValidacao()));
            Console.WriteLine("");

            Console.Write("ValidarRetornandoMensagem: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidador.ValidarRetornandoMensagem(inscricaoEstadual, uf)));
            Console.WriteLine("");

            Console.Write("Formatar: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidador.Formatar(inscricaoEstadual, uf)));
            Console.WriteLine("");

            Console.Write("ObterNomedaUf (método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidador.ObterNomedaUf(uf)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Ajuda: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidador.Ajuda()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Autor: ");
            Console.Write(PintaOpcaoEmDestaque(InscricaoEstadualValidador.Autor()));
        }

        private static void TestarValidacaoCepDocumentosBrasileiros()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                         Teste do validador de CEP / \"Zip code\" validator test                            ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Digite um CEP / Enter a Zip code number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string cep = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Limpar: ");
            cep = CepValidador.Limpar(cep);
            Console.Write(PintaOpcaoEmDestaque(cep));
            Console.WriteLine("");

            Console.Write("Validar: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidador.Validar(cep).ToString()));
            Console.WriteLine("");

            Console.Write("ObterUltimoCodigoDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidador.ObterUltimoCodigoDeValidacao()));
            Console.WriteLine("");

            Console.Write("ObterUltimaMensagemDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidador.ObterUltimaMensagemDeValidacao()));
            Console.WriteLine("");

            Console.Write("ValidarRetornandoMensagem: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidador.ValidarRetornandoMensagem(cep)));
            Console.WriteLine("");

            Console.Write("Formatar: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidador.Formatar(cep)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("CepExiste (método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(CepValidador.CepExiste(cep).ToString()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("ObterEnderecodoCepEmJson (método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(CepValidador.ObterEnderecodoCepEmJson(cep)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Ajuda: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidador.Ajuda()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Autor: ");
            Console.Write(PintaOpcaoEmDestaque(CepValidador.Autor()));
        }

        private static void TestarValidacaoPlacaVeicularDocumentosBrasileiros()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                    Teste do validador de placa veicular / \"Licence plate\" validator test                 ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");


            Console.Write("Digite um placa veicular / Enter a licence plate number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string placaVeicular = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Limpar: ");
            placaVeicular = PlacaVeicularValidador.Limpar(placaVeicular);
            Console.Write(PintaOpcaoEmDestaque(placaVeicular));
            Console.WriteLine("");

            Console.Write("Validar: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidador.Validar(placaVeicular).ToString()));
            Console.WriteLine("");

            Console.Write("ObterUltimoCodigoDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidador.ObterUltimoCodigoDeValidacao()));
            Console.WriteLine("");

            Console.Write("ObterUltimaMensagemDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidador.ObterUltimaMensagemDeValidacao()));
            Console.WriteLine("");

            Console.Write("ValidarRetornandoMensagem: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidador.ValidarRetornandoMensagem(placaVeicular)));
            Console.WriteLine("");

            Console.Write("Formatar: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidador.Formatar(placaVeicular)));
            Console.WriteLine("");

            Console.Write("IdentificaUFPlacaCinza (método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidador.IdentificaUFPlacaCinza(placaVeicular)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Ajuda: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidador.Ajuda()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Autor: ");
            Console.Write(PintaOpcaoEmDestaque(PlacaVeicularValidador.Autor()));
        }

        private static void TestarValidacaoCnhDocumentosBrasileiros()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                     Teste do validador de CNH / \"Driver's License\" validator test                        ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Digite um CNH / Enter a Driver's License number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string cnh = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Limpar: ");
            cnh = CnhValidador.Limpar(cnh);
            Console.Write(PintaOpcaoEmDestaque(cnh));
            Console.WriteLine("");

            Console.Write("Validar: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidador.Validar(cnh).ToString()));
            Console.WriteLine("");

            Console.Write("ObterUltimoCodigoDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidador.ObterUltimoCodigoDeValidacao()));
            Console.WriteLine("");

            Console.Write("ObterUltimaMensagemDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidador.ObterUltimaMensagemDeValidacao()));
            Console.WriteLine("");

            Console.Write("ValidarRetornandoMensagem: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidador.ValidarRetornandoMensagem(cnh)));
            Console.WriteLine("");

            Console.Write("Formatar: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidador.Formatar(cnh)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Ajuda: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidador.Ajuda()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Autor: ");
            Console.Write(PintaOpcaoEmDestaque(CnhValidador.Autor()));
        }

        private static void TestarValidacaoPassaporteDocumentosBrasileiros()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                     Teste do validador de Passaporte / \"Passport\" validator test                         ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");


            Console.Write("Digite um Passaporte / Enter a Passport number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string passaporte = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Limpar: ");
            passaporte = PassaporteValidador.Limpar(passaporte);
            Console.Write(PintaOpcaoEmDestaque(passaporte));
            Console.WriteLine("");

            Console.Write("Validar: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidador.Validar(passaporte).ToString()));
            Console.WriteLine("");

            Console.Write("ObterUltimoCodigoDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidador.ObterUltimoCodigoDeValidacao()));
            Console.WriteLine("");

            Console.Write("ObterUltimaMensagemDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidador.ObterUltimaMensagemDeValidacao()));
            Console.WriteLine("");

            Console.Write("ValidarRetornandoMensagem: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidador.ValidarRetornandoMensagem(passaporte)));
            Console.WriteLine("");

            Console.Write("Formatar: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidador.Formatar(passaporte)));
            Console.WriteLine("");

            Console.Write("Ajuda: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidador.Ajuda()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Autor: ");
            Console.Write(PintaOpcaoEmDestaque(PassaporteValidador.Autor()));
        }

        private static void TestarValidacaoRenavamDocumentosBrasileiros()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                        Teste do validador de RENAVAM / \"RENAVAM\" validator test                          ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Digite um RENAVAM / Enter a RENAVAM number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string renavam = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Limpar: ");
            renavam = RenavamValidador.Limpar(renavam);
            Console.Write(PintaOpcaoEmDestaque(renavam));
            Console.WriteLine("");

            Console.Write("Validar: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidador.Validar(renavam).ToString()));
            Console.WriteLine("");

            Console.Write("ObterUltimoCodigoDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidador.ObterUltimoCodigoDeValidacao()));
            Console.WriteLine("");

            Console.Write("ObterUltimaMensagemDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidador.ObterUltimaMensagemDeValidacao()));
            Console.WriteLine("");

            Console.Write("ValidarRetornandoMensagem: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidador.ValidarRetornandoMensagem(renavam)));
            Console.WriteLine("");

            Console.Write("Formatar: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidador.Formatar(renavam)));
            Console.WriteLine("");

            Console.Write("Ajuda: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidador.Ajuda()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Autor: ");
            Console.Write(PintaOpcaoEmDestaque(RenavamValidador.Autor()));
        }

        private static void TestarValidacaoDeCpfDocumentosBrasileiros()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                           Teste do validador de CPF  / \"CPF\" validator test                              ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Digite um CPF / Enter a CPF number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string cpf = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Limpar: ");
            cpf = CpfValidador.Limpar(cpf);
            Console.Write(PintaOpcaoEmDestaque(cpf));
            Console.WriteLine("");

            Console.Write("Validar: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidador.Validar(cpf).ToString()));
            Console.WriteLine("");

            Console.Write("ObterUltimoCodigoDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidador.ObterUltimoCodigoDeValidacao()));
            Console.WriteLine("");

            Console.Write("ObterUltimaMensagemDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidador.ObterUltimaMensagemDeValidacao()));
            Console.WriteLine("");

            Console.Write("ValidarRetornandoMensagem: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidador.ValidarRetornandoMensagem(cpf)));
            Console.WriteLine("");

            Console.Write("Formatar: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidador.Formatar(cpf)));
            Console.WriteLine("");

            Console.Write("ObterRegiaoFiscalDoCpf (método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidador.ObterRegiaoFiscalDoCpf(cpf)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Ajuda: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidador.Ajuda()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Autor: ");
            Console.Write(PintaOpcaoEmDestaque(CpfValidador.Autor()));
        }

        private static void TestarValidacaoTituloDeEleitorDocumentosBrasileiros()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                  Teste do validador de título de eleitor  / \"Voter card\" validator test                  ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");


            Console.Write("Digite um título de eleitor / Enter a voter card number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string titulo = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Limpar: ");
            titulo = TituloEleitoralValidador.Limpar(titulo);
            Console.Write(PintaOpcaoEmDestaque(titulo));
            Console.WriteLine("");

            Console.Write("Validar: ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidador.Validar(titulo).ToString()));
            Console.WriteLine("");

            Console.Write("ObterUltimoCodigoDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidador.ObterUltimoCodigoDeValidacao()));
            Console.WriteLine("");

            Console.Write("ObterUltimaMensagemDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidador.ObterUltimaMensagemDeValidacao()));
            Console.WriteLine("");

            Console.Write("ValidarRetornandoMensagem: ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidador.ValidarRetornandoMensagem(titulo)));
            Console.WriteLine("");

            Console.Write("Formatar (default): ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidador.Formatar(titulo)));
            Console.WriteLine("");

            Console.Write("Formatar (enviando separadores / método exclusivo): ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidador.Formatar(titulo, '-', '-')));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Ajuda: ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidador.Ajuda()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Autor: ");
            Console.Write(PintaOpcaoEmDestaque(TituloEleitoralValidador.Autor()));
        }

        private static void TestarValidacaoPisPasepDocumentosBrasileiros()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                      Teste do validador de PIS-PASEP  / \"PIS-PASEP\" validator test                       ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");


            Console.Write("Digite um PIS-PASEP / Enter a PIS-PASEP number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string pisPasep = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Limpar: ");
            pisPasep = PisPasepValidador.Limpar(pisPasep);
            Console.Write(PintaOpcaoEmDestaque(pisPasep));
            Console.WriteLine("");

            Console.Write("Validar: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidador.Validar(pisPasep).ToString()));
            Console.WriteLine("");

            Console.Write("ObterUltimoCodigoDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidador.ObterUltimoCodigoDeValidacao()));
            Console.WriteLine("");

            Console.Write("ObterUltimaMensagemDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidador.ObterUltimaMensagemDeValidacao()));
            Console.WriteLine("");

            Console.Write("ValidarRetornandoMensagem: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidador.ValidarRetornandoMensagem(pisPasep)));
            Console.WriteLine("");

            Console.Write("Formatar: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidador.Formatar(pisPasep)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Ajuda: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidador.Ajuda()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Autor: ");
            Console.Write(PintaOpcaoEmDestaque(PisPasepValidador.Autor()));
        }

        private static void TestarValidacaoDeCnpjDocumentosBrasileiros()
        {
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = corDeTitulo;
            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("||                          Teste do validador de CNPJ  / \"CNPJ\" validator test                             ||");
            Console.WriteLine("+============================================================================================================+");
            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");


            Console.Write("Digite um CNPJ / Enter a CNPJ number: ");
            Console.BackgroundColor = ConsoleColor.Blue;

            string cnpj = Console.ReadLine();

            Console.BackgroundColor = corDeFundo;
            Console.WriteLine("");

            Console.Write("Limpar: ");
            cnpj = CnpjValidador.Limpar(cnpj);
            Console.Write(PintaOpcaoEmDestaque(cnpj));
            Console.WriteLine("");

            Console.Write("Validar: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidador.Validar(cnpj).ToString()));
            Console.WriteLine("");

            Console.Write("ObterUltimoCodigoDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidador.ObterUltimoCodigoDeValidacao()));
            Console.WriteLine("");

            Console.Write("ObterUltimaMensagemDeValidacao: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidador.ObterUltimaMensagemDeValidacao()));
            Console.WriteLine("");

            Console.Write("ValidarRetornandoMensagem: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidador.ValidarRetornandoMensagem(cnpj)));
            Console.WriteLine("");

            Console.Write("Formatar: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidador.Formatar(cnpj)));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Ajuda: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidador.Ajuda()));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Autor: ");
            Console.Write(PintaOpcaoEmDestaque(CnpjValidador.Autor()));
        }


        private static void ExibirLogo()
        {
            Console.ForegroundColor = corDoLogo;
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("            -                                                                          .:             ");
            Console.WriteLine("            #*.                                                                       =@.             ");
            Console.WriteLine("            +@%-                                                                    .#@%              ");
            Console.WriteLine("            -@@@*.                                                                 =@@@#              ");
            Console.WriteLine("            :@@@@%-                                                              .#@@@@+              ");
            Console.WriteLine("             @@@@@@*.                                                           -%@@@@@-              ");
            Console.WriteLine("             #@@+%@@%-                                                        .*@@%*%@@.              ");
            Console.WriteLine("             +@@*+*@@@+                                                      -%@@#++@@%               ");
            Console.WriteLine("             -@@#+++%@@%:                                                  .*@@%*+++@@*               ");
            Console.WriteLine("             .@@%++++*@@@+                                                -%@@#++++*@@+               ");
            Console.WriteLine("              %@@++++++%@@%:                                            .*@@@*+++++#@@-               ");
            Console.WriteLine("              #@@+++++++*@@@+                                          -%@@#+++++++%@@.               ");
            Console.WriteLine("              +@@*++++++++%@@%:                                      .*@@@*++++++++@@%                ");
            Console.WriteLine("              -@@#+++%*++++#@@@+                                    -%@@%+++++#*+++@@*                ");
            Console.WriteLine("              .@@%+++%@#+++++%@@#:                                 +@@@*++++*@@*++*@@=                ");
            Console.WriteLine("               %@@+++%@@%*++++#@@@+                              :%@@%+++++%@@@+++#@@:                ");
            Console.WriteLine("               *@@+++#@@@@#+++++%@@#:                           +@@@*++++*@@@@%+++%@@.                ");
            Console.WriteLine("               =@@*++*@@@@@%*++++#@@@=                        :%@@%+++++%@@@@@%+++@@%                 ");
            Console.WriteLine("               -@@#+++@@@@@@@#+++++%@@#:.....................+@@@*++++*@@@@@@@#++*@@*                 ");
            Console.WriteLine("               .@@%+++@@@@@@@@@*++++#@@@@@@@@@@@@@@@@@@@@@@@@@@%+++++%@@@@@@@@*++*@@=                 ");
            Console.WriteLine("                %@@+++%@@@@@@@@@#+++++%%%%%%%%%%%%%%%%%%%%%%%%*++++*@@@@@@@@@@+++#@@:                 ");
            Console.WriteLine("                *@@+++#@@@@@@@@%++++++++++++++++++++++++++++++++++++#@@@@@@@@@+++%@@                  ");
            Console.WriteLine("                =@@*++*@@@@@@@#++++++++++++++++++++++++++++++++++++++*@@@@@@@%+++@@#                  ");
            Console.WriteLine("                :@@#++*@@@@@@*+++++++++++++++++++++++++++++++++++++++++%@@@@@#++*@@*                  ");
            Console.WriteLine("                .@@%+++@@@@%++++++++++++++++++++++++++++++++++++++++++++#@@@@#++#@@=                  ");
            Console.WriteLine("                 %@@+++%@@#++++++++++++++++++++++++++++++++++++++++++++++*@@@*++#@@:                  ");
            Console.WriteLine("                 *@@*++%@*+++++++++++++++++++++++++++++++++++++++++++++++++%@+++%@@                   ");
            Console.WriteLine("                 =@@#++*++++++++++++++++++++++++++++++++++++++++++++++++++++#+++@@#                   ");
            Console.WriteLine("                 :@@#++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*@@+                   ");
            Console.WriteLine("                  @@%++++++++++++++++++++++++++++++++++++++++++++++++++++++++++#@@=                   ");
            Console.WriteLine("                  %@@++++++++++++++++++++++++++++++++++++++++++++++++++++++++++%@@-                   ");
            Console.WriteLine("                 *@@#++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*@@%.                  ");
            Console.WriteLine("                =@@%++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*@@#                  ");
            Console.WriteLine("               -@@%++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++#@@*                 ");
            Console.WriteLine("              :@@@++++++++++*%##*+++++++++++++++++++++++++++++++++++*#%#++++++++++%@@=                ");
            Console.WriteLine("             .%@@*++++++++++++%@@@%#*++++++++++++++++++++++++++*#%@@@@*++++++++++++%@@-               ");
            Console.WriteLine("             #@@*++++++++++++++#@@@@@@@%#*+++++++++++++++++*#%@@@@@@%+++++++++++++++@@@:              ");
            Console.WriteLine("            *@@#++++++++++++++++*@@@@@@@@%#++++++++++++++*%@@@@@@@@#++++++++++++++++*@@%.             ");
            Console.WriteLine("           =@@%+++++++++++++++++++%@@@%*++++++++++++++++++++*#%@@@*++++++++++++++++++*@@#             ");
            Console.WriteLine("          -@@%+++++++++++++++++++++**+++++++++++++++++++++++++++*+++++++++++++++++++++#@@*            ");
            Console.WriteLine("         :@@@++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++%@@+           ");
            Console.WriteLine("        .%@@*+++++++++++++==++++++++++++++++++++++++++++++++++++++++++++==++++++++++++++%@@-          ");
            Console.WriteLine("        #@@*++++++++==-:.   .-++++++++++++++++++++++++++++++++++++++++=:   .:--=+++++++++@@@:         ");
            Console.WriteLine("       *@@#++++=-:..          .=++++++++++++++++++++++++++++++++++++=:           .:-==+++*@@%.        ");
            Console.WriteLine("      =@@%-::.                  .=++++++++++++++++++++++++++++++++=:                  ..:-*@@#        ");
            Console.WriteLine("     .%@@@%*-.                    :=+++++++++++++++++++++++++++++-                     :+#@@@@=       ");
            Console.WriteLine("       :=#@@@@#=.                   :=+++++++++++++++++++++++++-.                   -*%@@@%+-         ");
            Console.WriteLine("          .=*@@@@#+:                  :=++++++++*##*+++++++++-.                 .=*@@@@#+:            ");
            Console.WriteLine("              -+%@@@%+-                 -+++*#%@@@@@@%#*+++-.                :=#@@@@*=.               ");
            Console.WriteLine("                 :+#@@@@*=.              .=@@@@@@@@@@@@@@*.               -+%@@@%*-                   ");
            Console.WriteLine("                    .=#@@@@#=:             .*@@@@@@@@@@#-             .-*@@@@%+:                      ");
            Console.WriteLine("                       .-*%@@@%+:            :*@@@@@@%-            .=#@@@@#=.                         ");
            Console.WriteLine("                           :+%@@@%*-.          :#@@%=           :+%@@@%*-.                            ");
            Console.WriteLine("                              .=#@@@@#=.         -=         .-*%@@@%+:                                ");
            Console.WriteLine("                                 .-*@@@@%+:              .=#@@@@#=:                                   ");
            Console.WriteLine("                                     -+%@@@%*-        :+#@@@@*-.                                      ");
            Console.WriteLine("                                        :=#@@@@#=. -*%@@@%+-                                          ");
            Console.WriteLine("                                           .=*@@@@@@@@#+:                                             ");
            Console.WriteLine("                                               -*%@#=.                                                ");
            Console.WriteLine("                                                                                                      ");
        }

    }
}
