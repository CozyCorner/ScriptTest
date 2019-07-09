using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	// ----- 発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう ----- //
	public class Boss {        
		private int hp = 100;          // 体力
		private int power = 25; // 攻撃力

		// int型の変数mpを宣言し、53で初期化してください
		private int mp = 53;

		// 攻撃用の関数
		public void Attack() { 
			Debug.Log( this.power + "のダメージを与えた" );
		}

		// 防御用の関数
		public  void Defence(int damage) { 
			Debug.Log( damage+"のダメージを受けた" );
			// 残りhpを減らす
			this.hp -= damage;
		}

		// mpを消費して魔法攻撃をするMagic関数を作ってください
		public  void Magic() {
			// mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
			if (this.mp - 5 < 0) {
				Debug.Log ("MPが足りないため魔法が使えない。");
				return;
			}

			// Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。
			this.mp -= 5;
			Debug.Log( "魔法攻撃をした。残りMPは" + this.mp + "。" );
		}


	}





	void Start () {
		// ----- 課題：配列を宣言して出力しましょう ----- //
		// 要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
		int[] points = {10, 20, 30, 40, 50};

		// for文を使い、配列の各要素の値を順番に表示してください
		for (int i = 0; i < points.Length; i++) {
			Debug.Log (points [i]);
		}

		// for文を使い、配列の各要素の値を逆順に表示してください
		for (int i = points.Length - 1; i >= 0; i--) {
			Debug.Log (points [i]);
		}


		// ----- 発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう ----- //
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// Magic関数を呼び出して、魔法を使ってください
		lastboss.Magic();

		// Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください
		for (int i = 1; i <= 10; i++) {
			Debug.Log (i + "回目");
			lastboss.Magic();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
