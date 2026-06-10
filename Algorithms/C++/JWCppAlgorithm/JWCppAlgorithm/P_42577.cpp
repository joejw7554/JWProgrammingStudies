#include <iostream>
#include <string>
#include <vector>
#include <unordered_set>
#include <algorithm>
#include <sstream>

using namespace std;

//https://school.programmers.co.kr/learn/courses/30/lessons/42577

bool solution(vector<string> phone_book)
{

    unordered_set<string> hash;

    for (const auto& item : phone_book) 
    {
        hash.insert(item);
    }

    int n = phone_book.size();
    for (int i = 0; i < phone_book.size(); i++)
    {
        string currentNum = phone_book[i];
        ostringstream oss;


        for (int j = 0; j < currentNum.size() - 1; j++)
        {
            oss << currentNum[j];
            if (hash.find(oss.str()) != hash.end())
            {
                return false;
            }
        }
    }

    return true;
}

int main()
{
    cout << solution({ "119", "97674223", "1195524421" }) << endl;
    cout << solution({ "123", "456", "789" }) << endl;
    cout << solution({ "12", "123", "1235", "567", "88" }) << endl;

}
