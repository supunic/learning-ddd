// DTO（Data Transfar Object）
// ドメインオブジェクトをクライアントに直接公開しないためのクッション
// Userドメインオブジェクトをクライアントにそのまま返却すると、user.ChangeName()などで
// クライアントによってドメインオブジェクトを自由に変更できてしまう
// → アプリケーション層にあるべきロジックが散ってしまう原因となる
// → ドメインオブジェクトに依存するコードが増える原因となる（いざドメインオブジェクトを変更したときの影響範囲が広がってしまう）

public class UserData
{
    public UserData(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public string Id { get; }
    public string Name { get; }
}