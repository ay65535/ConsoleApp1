public class BananaDecorator : Decorator
{

    public BananaDecorator(SpongeCake spongeCake) : base(spongeCake)
    { // コンストラクタで飾り付けの対象を渡す
    }

    public override string getName()
    { // 中身の名前の先頭にバナナを加えたもの
        return "バナナ" + spongeCake.getName();
    }

    public override int getPrice()
    { // 中身の価格に300を加えたもの
        return spongeCake.getPrice() + 300;
    }

}
