namespace ConsoleApp1
{
    public class OrderDecorator : Decorator
    {
        public OrderDecorator(IecDefaultVar iecVar) : base(iecVar)
        { // コンストラクタで飾り付けの対象を渡す
        }

        public override string getName()
        { // 中身の名前の先頭にOrderedを加えたもの
            return "Ordered" + iecVar.getName();
        }

        public override int getPrice()
        { // 中身の価格に100を加えたもの
            return iecVar.getPrice() + 100;
        }

    }
}
