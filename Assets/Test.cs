using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public void Magic()
    {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            // mpが5未満だった場合
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{
    // 「Hello, UnityChan」と表示する関数
    void Hello()
    {
        Debug.Log("Hello, UnityChan");
    }

    // Start is called before the first frame update
    void Start()
    {
        int[] points = new int[5];

        // 配列の各要素に値を代入する
        points[0] = 100;
        points[1] = 333;
        points[2] = 555;
        points[3] = 111;
        points[4] = 888;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        // 配列の要素をすべて表示する
        for (int i = 4; i > -1; i--)
        {
            Debug.Log(points[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss midboss = new Boss();

        int n = 0;


        // 攻撃用の関数を呼び出す
        midboss.Attack();
        // 防御用の関数を呼び出す
        midboss.Defence(7);
        do
        {

            midboss.Magic();
            n += 1;
        }
        while (n < 11);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
