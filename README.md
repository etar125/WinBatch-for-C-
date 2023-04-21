# WinBatch для C#
Для того чтобы начать использовать, надо скачать саму библиотеку: [Релизы](https://github.com/etar125/WinBatch4CSharp/releases)  
  
Теперь добавляем её в наше решение: Проект -> Добавить ссылку -> Браузер сборок .NET -> Обзор. Ищете и выбираете библиотеку.  
  
Теперь нужно подключить её:
```cs
using System;
using WindowsBatch;

namespace Teeeeeeeeeest
{
	class Program
	{
		public static void Main(string[] args)
		{
			
		}
	}
}
```
Хорошо. Теперь давайте напишем код Windows Batch:
```cs
using System;
using WindowsBatch;

namespace Teeeeeeeeeest
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] code = 
			{
				"color 0a",
				"title TEST",
				"echo -=-=-=-=-=-=-=-=-=-",
				"echo.",
				"echo      Test app",
				"echo.",
				"echo -=-=-=-=-=-=-=-=-=-",
				"pause"
			};
		}
	}
}
```
Создаёт экземпляр класса WinBatch и вызываем метод Do():
```cs
using System;
using WindowsBatch;

namespace Teeeeeeeeeest
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] code = 
			{
				"color 0a",
				"title TEST",
				"echo -=-=-=-=-=-=-=-=-=-",
				"echo.",
				"echo      Test app",
				"echo.",
				"echo -=-=-=-=-=-=-=-=-=-",
				"pause"
			};
      var wb = new WinBatch(code);
			wb.Do();
		}
	}
}
```
Всё! Запускаем и смотрим результат:
![image](https://user-images.githubusercontent.com/116297277/233656096-c5396da6-0e7b-4563-8864-4fe42e5836d2.png)
  
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-

Сделано для версии 0.1
