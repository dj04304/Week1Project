using System.Threading.Channels;

namespace _3_10HomeWorkBlackJack
{
    /// <summary>
    /// 블랙 잭
    /// </summary>
    internal class Program
    {
        //카드 덱
        //SelectMany 를 사용, 2 + 4가지모양, 3 + 4가지 모양 ... A +  4가지 모양을 다시 List로 반환하는 코드
        static List<string> InitializeDeck()
        {
            string[] ranks = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = new[] { "♠", "♥", "◇", "♣" };
            return ranks.SelectMany(rank => suits, (rank, suit) => rank + suit).ToList();
        }
        
        // 게임 실행 함수
        static void PlayBlackJack()
        {
            List<string> deck = InitializeDeck();
            List<string> playerDeck = new List<string>();
            List<string> dealerDeck = new List<string>();

            // 플레이어 버스트시 false
            bool playerBust = false;

            string seperator = ", ";

            // 카드 나눠주기 단계
            playerDeck.Add(Shuffle(deck));
            dealerDeck.Add(Shuffle(deck));
            playerDeck.Add(Shuffle(deck));
            dealerDeck.Add(Shuffle(deck));


            // 게임 진행
            while(true)
            {
                // 나눠준 패 출력
                Console.WriteLine("플레이어 손패: " + string.Join(seperator, playerDeck));
                Console.WriteLine("딜러 손패: " + dealerDeck[0] + ", [뒷면]");
                
                // 버스트(21넘길)시 반복문 탈출 
                if (playerBust)
                {
                    break;
                }

                Console.WriteLine("카드를 Hit하시겠습니까? (Y/N)");
                string userInput = Console.ReadLine().ToUpper();

                // 플레이어 카드 계산단계
                if (userInput == "Y")
                {
                    playerDeck.Add(Shuffle(deck));
                    if (Calculator(playerDeck) > 21)
                    {
                        playerBust = true;
                        Console.WriteLine("플레이어 카드 버스트! 21이 넘었습니다!");
                    }
                }
                else if(userInput == "N")
                {
                    break;
                }else
                {
                    Console.Write("잘못된 입력입니다. 다시 입력해주세요!");
                }

                Console.Clear();
            }

            // 딜러 카드 계산단계
            while (Calculator(dealerDeck) < 17)
            {
                dealerDeck.Add(Shuffle(deck));
            }

            Console.Clear();
            Console.WriteLine("플레이어 손패: " + string.Join(seperator, playerDeck));
            Console.WriteLine("딜러 손패: " + string.Join(seperator, dealerDeck));

            //Log
            //foreach (string player in playerDeck)
            //{
            //    Console.WriteLine(player);
            //}

            //foreach (string deeler in dealerDeck)
            //{
            //    Console.WriteLine(deeler);
            //}

            GameOver(playerDeck, dealerDeck);

        }

        // 게임 종료 함수
        static void GameOver(List<string> playerDeck, List<string> dealerDeck)
        {
            if (Calculator(playerDeck) > 21 && Calculator(dealerDeck) > 21)
            {
                Console.WriteLine("무승부입니다!");
            }
            else if(Calculator(playerDeck) > 21)
            {
                Console.WriteLine("딜러 승리! 플레이어의 카드 버스트로 21이 넘었습니다!");
            }
            else if (Calculator(dealerDeck) > 21)
            {
                Console.WriteLine("플레이어 승리! 딜러의 카드 버스트로 21이 넘었습니다!");
            }
            else if (Calculator(playerDeck) > Calculator(dealerDeck))
            {
                Console.WriteLine("플레이어 승리! 플레이어의 수가 더 21에 가깝습니다!");
            }
            else if (Calculator(playerDeck) < Calculator(dealerDeck))
            {
                Console.WriteLine("딜러 승리! 딜러의 수가 더 21에 가깝습니다!");
            }
            else
            {
                Console.WriteLine("무승부입니다!");
            }
        }

        // 카드 덱을 가져와 랜덤한 값으로 셔플해줌
        static string Shuffle(List<string> deck)
        {
            Random random = new Random();

            int index = random.Next(0, deck.Count);

            string card = deck[index];

            return card;
        }

        //계산 함수
        static int Calculator(List<string> handCard)
        {
            int totalValue = 0;
            int aceCount = 0;

            foreach(string card in handCard)
            {
                string rank = card.Substring(0, card.Length - 1);

                if (int.TryParse(rank, out int cardValue))
                {
                    totalValue += cardValue;
                }
                else if(rank == "A")
                {
                    totalValue += 11;
                    aceCount++;
                }
                else
                {
                    totalValue += 10;
                }
            }

            while(aceCount > 0 && totalValue > 21)
            {
                totalValue -= 10;
                aceCount--;
            }

            return totalValue;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("========BLACK JACK!========");
            Console.WriteLine("블랙잭 게임 스타트!");

            // 게임 스타트, 게임 시작시 PlayBlackJack() 호출, 끝날 경우 계속 플레이하시겠습니까 호출
            while (true)
            {
                PlayBlackJack();

                Console.WriteLine("계속 플레이하시겠습니까? (Y/N)");
                if(Console.ReadLine().ToUpper() != "Y")
                {
                    break;
                }
                Console.Clear();
            }
            Console.WriteLine("게임 종료");
        }
    }
}
