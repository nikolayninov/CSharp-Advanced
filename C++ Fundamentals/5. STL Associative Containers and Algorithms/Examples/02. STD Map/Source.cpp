#include<iostream>
#include<string>
#include<utility>
#include<map>
using namespace std;

int main()
{
	map<string,int>cityPopulations=
	{
		pair<string,int>{"Gabrovo",58950},
		pair<string,int>{"Sofia",1307376},
		pair<string,int>{"Melnik",385}
	};

	cityPopulations["Sofia"]++;
	cityPopulations["Veliko Tarnovo"]=72938;
	cityPopulations.insert(pair<string, int>("Pliska", 0));
	cityPopulations.emplace("Lovech", 20000);
	map<string, int > ::iterator it;
	for (it = cityPopulations.begin(); it != cityPopulations.end(); ++it)
	{
		cout << it->first << " " << it->second << endl;
	}
	system("pause");
}