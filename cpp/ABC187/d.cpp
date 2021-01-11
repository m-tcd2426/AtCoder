#include <bits/stdc++.h>
using namespace std;
using ll = int64_t;

int main() {
    int n; cin >> n;
    vector<ll> v(n);
    ll tot = 0;
    for(int i=0; i<n; i++){
        ll a,b; cin >> a >> b;
        tot -= a;
        v[i] = a + (a + b);
    }

    sort(v.begin(),v.end());
    
    int ans = 0;

    while(tot <= 0){
        tot += v.back();
        v.pop_back();
        ans++;
    }

    cout << ans << endl;
}