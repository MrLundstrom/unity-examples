using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueEncoder : MonoBehaviour
{
    string scrambler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    int length;

    private void Start()
    {
        length = scrambler.Length - 1;
        print(encode(7503));
        print(decode(("CBA")));
    }

    string encode(int n) {
        int tmp = n;
        int tmpl = 0;
        while (tmp >= length) {
            tmpl++;
            tmp = Mathf.FloorToInt(tmp / length);
        }
        string s = "";
        for (int i = tmpl; i >= 0; i--)
        {
            int t = Mathf.FloorToInt(Mathf.Pow(length, i));
            int number = Mathf.FloorToInt(n / t) > 0 ? Mathf.FloorToInt(n / t) : Mathf.FloorToInt(n % t);
            n = Mathf.FloorToInt(n % t);
            s += scrambler[number];
        }
        return s;
    }

    int decode(string s) {
        int tmpl = s.Length;
        int n = 0;
        for (int i = 0; i<tmpl; i++) {
            n += scrambler.IndexOf(s[i]) * Mathf.FloorToInt(Mathf.Pow(length, tmpl - i - 1));
}

return n;
    }
}
