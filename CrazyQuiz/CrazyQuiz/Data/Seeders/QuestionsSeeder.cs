﻿namespace CrazyQuiz.Data.Seeders
{
    public class QuestionsSeeder : IDataSeeder
    {
        private readonly IQuestionsStore _store;

        public QuestionsSeeder(IQuestionsStore store)
        {
            _store = store;
        }

        public void Seed()
        {
            _store.SaveQuestion(
                "Qual elemento não pertence?", 4,
                "Carro",
                "Caminhão",
                "Cadeira de Rodas",
                "Barco"
            );
            
            _store.SaveQuestion(
                "Continue a sequência: < | > _ _ < | _ | > _ _ _ < | _ _ | >", 2,
                " _ _ _ < | _ |>",
                " _ _ _ _ < | _ _ _ | >",
                " _ _ _ _ < | _ | _ _ >",
                " _ _ _ _ _ < | >"
            );
            
            _store.SaveQuestion(
                "Qual o nome do criador do aplicativo que ajuda os desempregados a encontrar um emprego?", 3,
                "Classificados do Diário",
                "Mark Zuchenberg",
                "Steve Jobs",
                "Bill Gates"
            );

            _store.SaveQuestion(
                "Marque a resposta 5!", 3,
                "Ceis",
                "5",
                "120",
                "48"
            );

            _store.SaveQuestion(
                "Quantos lados possui um dado?", 1,
                "2",
                "4",
                "6",
                "8"
            );

            _store.SaveQuestion(
                "Como se conserta um pneu de um carro?", 2,
                "Usando uma ferramenta adequada",
                "Com as mãos",
                "Com um estepe",
                "Tapando os buracos"
            );

            _store.SaveQuestion(
                "Quanto vale 5 + K?", 3,
                "13",
                "5000",
                "18",
                "Nenhuma das respostas acima"
            );

            _store.SaveQuestion(
                "Q__m _e_co_r__ o __a_i_?", 1,
                "_e__o _l__re_ __b_al",
                "__s_o d_ __m_",
                "_ri_to__o C__o_bo",
                "P_r_ _a_ _e _am__h_"
            );

            _store.SaveQuestion(
                "Qual é o plural de \"ar-condicionado\"?", 4,
                "ar-condicionados",
                "ares-condicionado",
                "ares-condicionados",
                "Nenhuma das opções acima"
            );

            _store.SaveQuestion(
                "Toc toc?", 3,
                "Quem bate?",
                "Quem fala?",
                "Quem é?",
                "Quem sois?"
            );

            _store.SaveQuestion(
                "Qual é a comida que liga e desliga?", 4,
                "O tomate",
                "Uma lâmpada",
                "O strogonoff",
                "Leite enriquecido de ferro"
            );

            _store.SaveQuestion(
                "Quanto é 1 + 3?", 1,
                "B",
                "4",
                "D",
                "100"
            );

            _store.SaveQuestion(
                "Qual destes é o nome mais adequado para um rei?", 1,
                "Mufasa",
                "Arthur",
                "Pedro",
                "Herodes"
            );

            _store.SaveQuestion(
                "Qual é o equipamento mais adequado para escalar uma montanha?", 2,
                "Corda",
                "Régua",
                "Luvas",
                "Picaretas"
            );

            _store.SaveQuestion(
                "Qual o número usado pelos astrólogos para indicar uma estrela vermelha?", 2,
                "45",
                "13",
                "22",
                "65"
            );

            _store.SaveQuestion(
                "Qual destes objetos é o mais verde?", 1,
                "Carvalho seco",
                "Tala Verde",
                "Ísis Valverde",
                "40"
            );

            _store.SaveQuestion(
                "Você acha que vai acertar todas as questões?", 3,
                "Pode apostar!",
                "Tenho esperança!",
                "Talvez um dia?",
                "Nem sonhando!"
            );

            _store.SaveQuestion(
                "Quanto é 8246 - 48?", 3,
                "8197",
                "48",
                "26",
                "1"
            );

            _store.SaveQuestion(
                "Qual é o prêmio que você ganha ao responder esta questão?", 3,
                "Glória eterna",
                "Um milhão de reais",
                "Mais perguntas",
                "Um lugar na tabela de pontuações"
            );

            _store.SaveQuestion(
                "Pmpaprpqpupe pap prpepspppopsptpa pdpopipsp!p", 2,
                "1",
                "2",
                "3",
                "4"
            );

            _store.SaveQuestion(
                "Qual a razão da vida?", 4,
                "Comer",
                "Dormir",
                "Esbanjar no funk ostentação",
                "Finalizar o Crazy Quiz"
            );

            _store.SaveQuestion(
                "Qual famoso cientista tem os \"olhos nota 10\"?", 3,
                "Newton",
                "Darwin",
                "Einstein",
                "Galileu"
            );
        }
    }
}
