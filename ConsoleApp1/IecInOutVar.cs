namespace ConsoleApp1
{
    public class IecInOutVar : IecDefaultVar
    {

        public override string getName()
        { // 親クラスの名前を得るメソッドをオーバーライド
            return "IecInOutVar";
        }

        public override int getPrice()
        { // 親クラスの価格を得るメソッドをオーバーライド
            return 700;
        }

    }
}
