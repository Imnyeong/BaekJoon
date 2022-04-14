using System;
using System.Collections.Generic;

class Solution
{
	static void Main()
	{
		string[] readLine = Console.ReadLine().Split(' '); // 입력 받기

		int N = Convert.ToInt32(readLine[0]); // N 입력
		int K = Convert.ToInt32(readLine[1]); // K 입력

		int[] coinList = new int [N]; // N 개의 동전이 들어갈 배열
		int count = 0; // 총 동전의 개수

		for(int i = 0; i < N; i++) // 동전의 종류 배열에 입력
        { coinList[i] = Convert.ToInt32(Console.ReadLine()); }

		Console.Write(N.ToString());
		Console.Write(" / ");
		Console.WriteLine(K.ToString());
		for (int j = 0; j < N; j++) // 동전의 종류 배열 출력
		{ Console.WriteLine(coinList[j].ToString()); }

		Array.Sort(coinList); // 동전 종류 가격 별로 정렬

		for(int i = N -1 ; i > -1; i--)
        {
			if(coinList[i] <= K) // 현재 금액이 동전의 값보다 크다면
            {
				Console.WriteLine(coinList[i].ToString() + " 원 짜리 동전 " + K / coinList[i] + " 개 추가"); 
				int currentCount = K / coinList[i]; // 현재 동전 필요한 개수
				count += currentCount; // 총 필요한 동전 개수 계산
				K -= (coinList[i] * currentCount); // 남은 금액 계산
				Console.WriteLine("남은 금액 " + K.ToString());
			}
			if(K == 0) // 0원 남았다면 반복문 탈출
			{ break; }
        }
		Console.WriteLine(count.ToString());
	}
}
