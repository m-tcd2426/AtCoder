#include <bits/stdc++.h>
using namespace std;

int s(string n){
    return n[0]-'0' + n[1]-'0' + n[2]-'0';
}

int main() {
    string a,b;
    cin >> a >> b;
    cout << max(s(a),s(b)) << endl;
}