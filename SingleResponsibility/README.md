# Single Responsibility Principle

Bir yazılım projesinde tasarlanan sınıflar (class) ve yapılar (struct), bazen benzer görevleri yerine getirebilmektedir. Böyle durumlarda sınıfların hangi görevleri yerine getireceği konusunda karışıklıklar ortaya çıkabilmektedir. Single Responsibility Prensibine göre bu tarz karmaşanın önüne geçmek için sınıfların ve yapıların iyi tanımlanmış tek sorumluluğu olması gerekmektedir. Eğer bir sınıf birden fazla görevin yerine getirilmesinden sorumlu olursa, gelecekte bu sınıfın değişme ihtimalini de arttırmaktadır. Bu da yazılım tasarımının bozulacağı anlamına gelmektedir.

Bu çalışmada öncelikle SRP’ye uygun olmayan basit bir tasarımla başlanarak, onu SRP’ye uygun hale getirilmeye çalışılmıştır.

Ayrıntılı Blog Yazısı: http://omereryilmaz.com/single-responsibility-principle/

&nbsp;
&nbsp;

##### Kaynaklar
- [1] The Principles of OOD, http://butunclebob.com/ArticleS.UncleBob.PrinciplesOfOod 
- [2] Robert C. Martin and Micah Martin, “Agile Principles, Patterns, and Practices in C#”, 2006.
- [3] Code Maze, https://code-maze.com/solid-principles/
- [4] Nesneye Yönelik Programlama, https://acikogretim.istanbul.edu.tr/