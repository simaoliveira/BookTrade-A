namespace BookTrade.Migrations {
    using BookTradeA.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookTradeA.Models.ApplicationDbContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BookTradeA.Models.ApplicationDbContext context) {
            var autor = new List<Autor> {
                new Autor {Id=1,Nome="Paulo Duarte", DataNasc=new DateTime(1979,03,14),Descricao="Paulo Duarte, sj. (1979 - Portim�o) - Jesu�ta, padre, coordenador da pastoral e professor no Col�gio das Caldinhas (Sto. Tirso). S�o muitas as pessoas que acompanha diariamente: em aulas, em conversas, em celebra��o de missa e reconcilia��o. �A presen�a nas redes sociais e ocasionalmente em programas televisivos permite uma comunica��o� ampla com a sociedade atual."},
                new Autor {Id=2,Nome="Raul Minh'alma", DataNasc=new DateTime(1992,05,14),Descricao="Nasceu em 1992, � natural do Marco de Canaveses, formado em Engenharia Mec�nica na Faculdade de Engenharia da Universidade do Porto. Come�ou a escrever poesia com dezassete anos e em 2011 lan�a o seu primeiro livro de poemas com o t�tulo"},
                new Autor {Id=3,Nome="Heather Morris", DataNasc=new DateTime(1953,07,20),Descricao="Heather Morris nasceu na Nova Zel�ndia e reside atualmente na Austr�lia. Durante v�rios anos, enquanto trabalhava num hospital p�blico em Melbourne, estudou e escreveu argumentos para cinema. "},
                new Autor {Id=4,Nome="Helena Sacadura Cabral", DataNasc=new DateTime(1950,10,03),Descricao="Al�m de colunista de diversos jornais e revistas, mant�m colabora��o regular em televis�o. Autora de duas dezenas de livros, concilia ainda a participa��o activa com a atualiza��o dos seus quatros blogues."},
                new Autor {Id=5,Nome="Lars Kepler", DataNasc=new DateTime(1960,03,20),Descricao="Lars Kepler � o pseud�nimo de uma dupla de escritores de sucesso na Su�cia: Alexander Ahndoril e Alexandra Coelho Ahndoril. O Hipnotista, primeiro volume da saga, alcan�ou um enorme sucesso internacional e foi adaptado ao cinema pela m�o do realizador Lasse Hallstr�m"},
                new Autor {Id=6,Nome="Herberto Helder", DataNasc=new DateTime(1980,04,30),Descricao="Herberto Helder nasceu em 1930 no Funchal, onde concluiu o 5.� ano. Em 1948 matriculou-se em Direito mas cedo abandonou esse curso para se inscrever em Filologia Rom�nica, que frequentou durante tr�s anos. Teve in�meros trabalhos e colaborou em v�rios peri�dicos como A Briosa"},
            };
            autor.ForEach(dd => context.Autor.AddOrUpdate(d => d.Nome, dd));
            context.SaveChanges();

            var categ = new List<Categorias> {
                new Categorias {Id=1,Nome="Infantis e Juvenis"},
                new Categorias {Id=2,Nome="Literatura"},
                new Categorias {Id=3,Nome="Politica"},
                new Categorias {Id=4,Nome="Crime"},
                new Categorias {Id=5,Nome="Hist�ria"},
                new Categorias {Id=6,Nome="Religi�o"},
            };
            categ.ForEach(dd => context.Categorias.AddOrUpdate(d => d.Nome, dd));
            context.SaveChanges();

            var livro = new List<Livro> {
                new Livro {Id=1,Titulo="O Ca�ador",Sinopse="A noite tinha acabado de cair, quando Sofia entra numa mans�o nos arredores de Estocolmo, onde o seu cliente - um homem muito abastado que nunca viu - a espera. Talvez seja por isso que Sofia avan�a furtivamente, como um animal selvagem.",AnoLanc=2018,Editora="Porto Editora",Idioma="Portugu�s",NumeroDePaginas=568,AutorId=5},
                new Livro {Id=2,Titulo="Uma Certa Forma de Vida",Sinopse="Neste livro, a autora come�a por abordar temas que marcam a vida moderna, mas que a podem transformar negativamente, se n�o estivermos atentos. ",AnoLanc=2018,Editora="Clube do Autor",Idioma="Portugues",NumeroDePaginas=184,AutorId=4},
                new Livro {Id=3,Titulo="O Tatuador de Auschwitz",Sinopse="Esta � a hist�ria assombrosa do tatuador de Auschwitz e da mulher que conquistou o seu cora��o - um dosepis�dios mais extraordin�rios e inesquec�veis do Holocausto.",AnoLanc=2018,Editora="Editorial Presen�a",Idioma="Portugues",NumeroDePaginas=232,AutorId=3},
                new Livro {Id=4,Titulo="Em min�sculas",Sinopse="Embora n�o esteja aqui coligida a totalidade das suas colabora��es, todos os textos deste livro foram publicados no Not�cia - Seman�rio Ilustrado, no per�odo em que Herberto Helder viveu em Luanda. ",AnoLanc=2018,Editora="Porto Editora",Idioma="Portugues",NumeroDePaginas=200,AutorId=6},
                new Livro {Id=5,Titulo="D�-me um Dia para Mudar a Tua Vida",Sinopse=" Aqui encontras 500 mensagens inspiradoras para leres e refletires no teu dia a dia. Ser�o a tua b�ssola.",AnoLanc=2018,Editora="Manuscrito Editora",Idioma="Portugues",NumeroDePaginas=200,AutorId=2},
                new Livro {Id=6,Titulo="Deus Como Tu",Sinopse="Deus Como Tu conduz-nos num regresso � f�, humana, vivida no quotidiano, e coloca-nos quest�es que nos fazem a pensar em temas como a morte, a culpa, a solid�o, mas tamb�m, o riso, a alegria e a liberdade.",AnoLanc=2018,Editora="Mat�ria Prima",Idioma="Portugues",NumeroDePaginas=168,AutorId=1},
            };
            livro.ForEach(dd => context.Livro.AddOrUpdate(d => d.Titulo, dd));
            context.SaveChanges();

            var user = new List<Utilizador> {
                new Utilizador {Id=1,UserName="simaoliveira",DataNasc=new DateTime(1996,10,02),Email="simaoliveira@ipt.pt",NomeCompleto="Simao Pedro De Oliveira Moleiro"},
                new Utilizador {Id=2,UserName="rafandreg",DataNasc=new DateTime(1996,05,03),Email="rafandreg@ipt.pt",NomeCompleto="Rafael Andre Campos Goncalves"},
                new Utilizador {Id=3,UserName="tixinha",DataNasc=new DateTime(1995,10,02),Email="tixinha@ipt.pt",NomeCompleto="Patricia Sofia Magalhaes Faustino"},
                new Utilizador {Id=4,UserName="bokica",DataNasc=new DateTime(1995,07,02),Email="bokica@ipt.pt",NomeCompleto="Beatriz Bangura da Silva Okica de Sa"},
                new Utilizador {Id=5,UserName="cmartins",DataNasc=new DateTime(1999,06,16),Email="cmartins@ipt.pt",NomeCompleto="Claudia Marisa Ferreira Martins"},
                new Utilizador {Id=6,UserName="sdias",DataNasc=new DateTime(1992,05,18),Email="sdias@ipt.pt",NomeCompleto="Ana Sofia Mendes Dias"},
            };
            user.ForEach(dd => context.Utilizador.AddOrUpdate(d => d.UserName, dd));
            context.SaveChanges();

            var coment = new List<Comentarios> {
                new Comentarios {Id=1,Texto="Adoro! Muito Emocionante",Data=new DateTime(2016,10,03),LivroId=3,UtilizadorId=1},
                new Comentarios {Id=2,Texto="Muito Bom, recomendo!",Data=new DateTime(2017,03,10),LivroId=4,UtilizadorId=5},
                new Comentarios {Id=3,Texto="5 estrelas, Fantastico",Data=new DateTime(2018,01,26),LivroId=1,UtilizadorId=3},
                new Comentarios {Id=4,Texto="Ficou um pouco �quem das expectativas",Data=new DateTime(2017,12,06),LivroId=2,UtilizadorId=6},
                new Comentarios {Id=5,Texto="bom mas tedioso",Data=new DateTime(2016,05,15),LivroId=6,UtilizadorId=4},
                new Comentarios {Id=6,Texto="Teve um bom inicio mas um p�ssimo final",Data=new DateTime(2017,11,17),LivroId=5,UtilizadorId=2},
            };
            coment.ForEach(dd => context.Comentarios.AddOrUpdate(d => d.Texto, dd));
            context.SaveChanges();

        }
    }
}
