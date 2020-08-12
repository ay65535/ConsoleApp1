public class StrawberryDecorator : Decorator
{

    public StrawberryDecorator(SpongeCake spongeCake) : base(spongeCake)
    { // コンストラクタで飾り付けの対象を渡す
    }

    public override string getName()
    { // 中身の名前の先頭にイチゴを加えたもの
        return "イチゴ" + spongeCake.getName();
    }


    public override int getPrice()
    { // 中身の価格に100を加えたもの
        return spongeCake.getPrice() + 100;
    }

}
