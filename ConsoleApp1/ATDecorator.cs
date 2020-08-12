namespace ConsoleApp1
{
    public class ATDecorator : Decorator
    {

        public ATDecorator(IecVar iecVar) : base(iecVar)
        { // コンストラクタで飾り付けの対象を渡す
        }

        public override string getName()
        { // 中身の名前にATを加えたもの
            return iecVar.getName() + "withAT";
        }

        public override int getPrice()
        { // 中身の価格に300を加えたもの
            return iecVar.getPrice() + 300;
        }

    }
}
