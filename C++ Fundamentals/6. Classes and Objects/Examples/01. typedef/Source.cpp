#include<iostream>
#include<string>
#include<map>
#include<vector>
using namespace std;

typedef string TenStrings[10];

void printArray(TenStrings strings)
{
	for (int i = 0; i < 10; ++i)
	{
		cout << strings[i] << " ";
		cout << endl;
	}
}

int main()
{
	typedef unsigned long long ull;
	ull number = 42;
	TenStrings words = { "the","quick","brown","fox","jumps","over","the","lazy","dog","!" };
	printArray(words);
	cout << endl;
}