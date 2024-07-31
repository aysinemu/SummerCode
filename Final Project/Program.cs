using System;
using System.Collections.Generic;	
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Tu Đu Lit");
		List<string> todoListItems = new List<string>();
		while (true)
		{
			Console.WriteLine("Lua chon:");
			Console.WriteLine("0 - Thoat");
			Console.WriteLine("1 - Xem");
			Console.WriteLine("2 - Them");
			Console.WriteLine("3 - Xao");
			string userInput = Console.ReadLine();
			int optionId;
			bool optionParseResult = int.TryParse(userInput, out optionId);
			if (!optionParseResult)
			{
				Console.WriteLine("Viet so lam gi!");
				continue;
			}
			if (optionId == 0)
			{
				break;	
			}
			if (optionId == 1)
			{
				Console.WriteLine("Danh sach:");
				for (int i = 0; i < todoListItems.Count; i++)
				{
					string item = todoListItems[i];
					Console.WriteLine("\t" + i + " - " + item);
				}
			}
			else if (optionId == 2)
			{
				Console.WriteLine("Them gi thi ghi vao đi:");
				string newTodoListItem = Console.ReadLine();
				todoListItems.Add(newTodoListItem);
			}
			else if (optionId == 3) 
			{
				Console.WriteLine("Cho tao con so:");
				string userInputForRemoveIndex = Console.ReadLine();
				int removeIndex;
				bool removeIndexParseResult = int.TryParse(userInputForRemoveIndex, out removeIndex);
				if (!removeIndexParseResult)
				{
					Console.WriteLine("Cai nay co phai so eo dau!");
					continue;
				}
				if (removeIndex < 0 || removeIndex >= todoListItems.Count)
				{
					Console.WriteLine("So nho thoi ba, dung nho qua dm!");
					continue;
				}
				todoListItems.RemoveAt(removeIndex);
			}
			else
			{
				Console.WriteLine("Tao chiu r!");
			}
		}
		Console.WriteLine("COOKKKKKKKKKKKKKKKKKKKKK");
	}
}