using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PTest1022 {
    class Program {
        //問題１（条件演算子）
        private void Exam_1() {
            int inputNum;
            string outStr = ""; //出力用文字列格納用

            Console.Write("〇問題１ 数字を入力して下さい：");
            inputNum = int.Parse(Console.ReadLine());

            //以下のように出力する。
            //但し、条件演算子を使用し、出力する文字列は outStr を使用すること
            //５以下…「５以下です」
            //６以上…「６以上です」

            /*** ●●● ここへ解答を入力 ●●● ***/
            




            /*** ●●●●● ここまで ●●●●● ***/
            Console.WriteLine($"結果：{outStr}\n");
        }

        //問題２（null合体演算子）
        private void Exam_2() {
            int data = 0;   //エラーが出ないように初期値として０を入れている

            //Exam_2_Stab()を呼び出して、返ってきた整数値を変数dataに格納する。
            //もし、nullが返ってきたら「-9999」を格納する。 
            //※動作チェックする場合は「Exam_2_Stab()を使用すること」

            /*** ●●● ここへ解答を入力 ●●● ***/






            /*** ●●●●● ここまで ●●●●● ***/
            Console.WriteLine($"〇問題２：{data}\n");
        }

        //問題２テスト用スタブ
        private int? Exam_2_Stab() {
            //▼▼▼▼▼　以下のコメントを切り替えて確認をする 
            //return null;
            return 150;
            //▲▲▲▲▲
        }

        //問題３（null条件演算子）
        private void Exam_3() {
            string title = "";

            //▼▼▼▼▼　以下のコメントを切り替えて確認をする 
            Book book = new Book() { Title = "銀河鉄道の夜", Price = 411, Pages = 276 };
            //Book book = new Book();
            //▲▲▲▲▲

            //bookオブジェクトのタイトル名を出力せよ
            //bookオブジェクトがnullの場合はそのままnullを返却すること
            /*** ●●● ここへ解答を入力 ●●● ***/





            /*** ●●●●● ここまで ●●●●● ***/
            //nullの場合は何も出力されません
            Console.WriteLine($"〇問題３：{title}");
        }

        //問題４
        private void Exam_4() {
            Console.WriteLine($"\n〇問題４");
            var books = new Books().GetBooks();
            int pageSum = 0;

            //金額が1200円以上の書籍を抽出せよ
            //出力については「タイトル」と「金額」を出力すること
            
            /*** ●●● ここへ解答を入力 ●●● ***/





            /*** ●●●●● ここまで ●●●●● ***/
            Console.WriteLine($"ページの合計は{ pageSum }ページです。");
        }

        //問題５
        private void Exam_5() {
            Console.WriteLine($"\n〇問題５");
            var books = new Books().GetBooks();

            //タイトルに「物語」が含まれていて、400ページ以上の書籍を抽出せよ
            //出力については「タイトル」と「ページ数」を出力すること

            /*** ●●● ここへ解答を入力 ●●● ***/





            /*** ●●●●● ここまで ●●●●● ***/
        }

        //問題６
        private void Exam_6(int[] numbers) {
            Console.WriteLine($"\n〇問題６");

            //引数で受け取った numbers を降順に並べ替え、重複を排除して出力せよ
            //出力については改行をせず、ヨコにスペースを空けて出力する
            // 出力例）79 65 53 45 35 34 20 12
            /*** ●●● ここへ解答を入力 ●●● ***/





            /*** ●●●●● ここまで ●●●●● ***/
        }

        //問題７
        private void Exam_7(int[] numbers) {
            Console.WriteLine($"\n\n〇問題７");
            double avg = 0.0;

            //引数で受け取った numbers の平均を変数 avg に求めよ
            /*** ●●● ここへ解答を入力 ●●● ***/






            /*** ●●●●● ここまで ●●●●● ***/

            Console.WriteLine($"平均値は{avg:0.0}です");
        }

        //問題８
        private void Exam_8(int[] numbers) {
            Console.WriteLine($"\n〇問題８");

            //引数で受け取った numbers の各値を３倍した値を出力せよ
            //出力については改行をせず、ヨコにスペースを空けて出力する
            // 出力例）60 36 135 195 102 105 195 159 237

            /*** ●●● ここへ解答を入力 ●●● ***/






            /*** ●●●●● ここまで ●●●●● ***/            
        }

        static void Main(string[] args) {
            //staticの使用を避けるために自分自身のインスタンスを生成
            new Program();
        }
        //コンストラクタ
        public Program() {
            var numbers = new[] { 20, 12, 45, 65, 34, 35, 65, 53, 79 };

            this.Exam_1();   //問題１
            this.Exam_2();   //問題２
            this.Exam_3();   //問題３
            this.Exam_4();   //問題４
            this.Exam_5();   //問題５
            this.Exam_6(numbers);   //問題６
            this.Exam_7(numbers);   //問題７
            this.Exam_8(numbers);   //問題８
        }

    }
}