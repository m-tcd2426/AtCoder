#include <bits/stdc++.h>
using namespace std;

int main() {
    int n; cin >> n;
    vector<pair<int,int>> p(n);
    for(int i=0; i<n; i++) cin >> p[i].first >> p[i].second;

    int ans = 0;
    for(int i=0; i<n; i++){
        for(int j=i+1; j<n; j++){
            double x1 = (double)p[i].first;
            double y1 = (double)p[i].second;
            double x2 = (double)p[j].first;
            double y2 = (double)p[j].second;
            double grd = (y2 - y1) / (x2 - x1);
            if(-1 <= grd && grd <= 1) ans++;
        }
    }
    cout << ans << endl;
}