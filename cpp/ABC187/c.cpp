#include <bits/stdc++.h>
using namespace std;

int main() {
    int n; cin >> n;
    vector<string> s(n);
    for(int i=0; i<n; i++){
        cin >> s[i];
        if(s[i][0] == '!') s[i] = s[i].substr(1,s[i].length()-1) + "!";
    }
    sort(s.begin(),s.end());
    for(int i=1; i<n; i++){
        if(s[i] == s[i-1] + "!"){
            cout << s[i-1] << endl;
            return 0;
        }
    }
    cout << "satisfiable" << endl;
}