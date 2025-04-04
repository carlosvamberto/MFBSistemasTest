# MFB Materiaus Elétricos SA

## Conexão com Banco de Dados

O arquivo DataContext que está em MFBSistemas\Models\LocalDBMSSQLLocalDBContext.cs contém o código para setar o local em que o arquivo .MDF está localizado.
Este arquivo foi gerado por scaffold.

```cs
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\MFBSistemas\\MFBSistemas\\Database\\Database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
```

É concelhavel colocar o projeto na raiz da unidade C: para que fique como foi desenvolvido.
Ou mudar o código acima, o caminho onde o projeto foi clonado.

Feito por Carlos Vamberto Filho
