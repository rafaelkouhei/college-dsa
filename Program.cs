using System;
using System.Collections.Generic;
using System.Linq;

namespace stack 
{
	class stack 
	{
		private char[] elem;
		private int top;
		private int size;

		public stack(int capacity)
		{
			elem = new char[capacity];
			top = -1;
			size = 0;
		}

		public void push(char ch)
		{
			elem[++top] = ch;
			size++;
		}

		public void showStack()
		{
			Console.WriteLine("Queue: ");
			for(int i = top; i >= 0; i--)
			{
				Console.WriteLine(" " + elem[i]);
			}
			Console.WriteLine();
		}

		public int showSize()
		{
			return size;
		}

		public char showTop()
		{
			return elem[top];
		}

		public char pop()
		{
			char c = elem[top--];
			top--;
			return c;
		}
	}

	internal class Program 
	{
		static void Main()
		{
			stack stack = new stack(10);
			char option;

			do
			{
				Console.WriteLine("Choose an option: ");
				Console.WriteLine("1 - Append element to the stack");
				Console.WriteLine("2 - Remove element from the stack");
				Console.WriteLine("3 - Show stack elements");
				Console.WriteLine("4 - Show stack top element");
				Console.WriteLine("5 - Show stack's size");
				Console.WriteLine("0 - Leave");
				option = Console.ReadKey().KeyChar;
				Console.WriteLine();

				switch(option)
				{
					case '1':
						Console.WriteLine("Insert the character to be stacked");
						char ch = Console.ReadKey().KeyChar;
						break;
					case '2':
						Console.WriteLine("Insert the character to be removed");
						char ch = Console.ReadKey().KeyChar;
						break;
					case '3':
						stack.showStack();
						break;
					case '4':
						stack.showTop();
						break;
					case '5':
						stack.showSize();
						break;
					case '0':
						Console.WriteLine("Leaving...");
						break;
					default:
						Console.WriteLine("Invalid option...");
						break;
				}

			} while(option != 0);
		}
	}
}

namespace queue
{
	class queue
	{
		private char[] arr;
		private int head;
		private int tail;
		private int head;
		private int size;
		private int capacity;

		public static queue(int capacity)
		{
			this.capacity = capacity;
			arr = new char[capacity];
			head = 0;
			tail = -1;
			size = 0;
		}

		public void enqueue(char ch)
		{
			tail = (tail + 1) % capacity;
			arr[tail] = ch;
			size++;
		}

		public void dequeue(char ch)
		{
			if(isEmpty())
			{
				Console.WriteLine("Empty Queue!");
				return '\0';
			}
			char val = arr[head];
			head = (head + 1) % capacity;
			size--;

			return val;
		}

		public bool isEmpty()
		{
			return size == 0;
		}

		public void peek()
		{
			Console.WriteLine(arr[0]);
		}

		public void show()
		{
			Console.Write("Queue: ");
			for(int i = 0; i < size; i++)
			{
				int index = (i + 1) % size;
				Console.Write(arr[index] + " ");
			}
			Console.WriteLine();
		}
	}

namespace MyListImplementation
{
	class MyList
	{
		private char[] elem;
		private int size;
		private int capacity;

		public MyList(int capacity)
		{
			this.capacity = capacity;
			elem = new char[capacity];
			size = 0;
		}

		public void Insert(char val)
		{
			if(size == capacity)
			{
				Console.WriteLine("Full List!");
				return;
			}
			elem[size] = val;
			size++;
		}

		public void InsertByIndex(int index, char val)
		{
			if(size == capacity)
			{
				Console.WriteLine("Full List!");
				return;
			}

			if(index < 0 || index > size)
			{
				Console.WriteLine("Invalid index!");
			}

			for(int i = size; i > index; i--)
			{
				elem[i] = elem[i - 1];
			}
			elem[index] = val;
			size++;
		}

		public void RemoveByIndex(int index)
		{
			if(index < 0 || index > size)
			{
				Console.WriteLine("Invalid index!");
				return;
			}

			for(int i = index; i < size - 1; i++)
			{
				elem[i] = elem[i + 1];
			}
			size--;
		}

		public void ShowListContent()
		{
			if(size == 0)
			{
				Console.WriteLine("Empty List!");
				return;
			}
			Console.Write("List: ");
			for(int i = 0; i < size; i++)
			{
				Console.Write(elem[i] + " ");
			}
			Console.WriteLine();
		}

		public int ShowListSize()
		{
			return size;
		}
	}
	public class Program
	{
		static void Main(string[] args)
		{
			MyList MyListObj = new MyList(10);
			int option, index;
			char val;

			do
			{
				Console.WriteLine("Welcome to My List Implementation!\nChoose one of the options below:");
				Console.WriteLine("1. Insert");
				Console.WriteLine("2. Insert by Index");
				Console.WriteLine("3. Remove by Index");
				Console.WriteLine("4. Show List Content");
				Console.WriteLine("5. Show List Size");
				Console.WriteLine("6. Leave");

				option = int.Parse(Console.ReadLine());
			} while (option != 6);

		}
	}
}