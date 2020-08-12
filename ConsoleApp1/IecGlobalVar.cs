namespace ConsoleApp1
{
    public class IecGlobalVar : IecVar
    {

        public override string getName()
        { // 親クラスの名前を得るメソッドをオーバーライド
            return "IecGlobalVar";
        }

        public override int getPrice()
        { // 親クラスの価格を得るメソッドをオーバーライド
            return 500;
        }

    }
}
