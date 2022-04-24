using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListApp
{
    public partial class MainPage : ContentPage
    {
        public IList<Band> Bands { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Bands = new List<Band>();

            Bands.Add(new Band()
            {
                Name = "Iron Maiden",
                Description = "Iron Maiden are an English heavy metal band formed in Leyton, East London, in 1975 by bassist and primary songwriter Steve Harris. The band's discography has grown to 41 albums, including 17 studio albums, 13 live albums, four EPs, and seven compilations. They have also released 47 singles and 20 video albums. Two electronic games have been released with Iron Maiden soundtracks, and the band's music is featured in a number of other video games.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/7/7c/Iron_Maiden_Logo.png"
            });
            Bands.Add(new Band()
            {
                Name = "Led Zeppelin",
                Description = "Led Zeppelin were an English rock band formed in London in 1968. The group consisted of vocalist Robert Plant, guitarist Jimmy Page, bassist/keyboardist John Paul Jones, and drummer John Bonham. With a heavy, guitar-driven sound, they are cited as one of the progenitors of hard rock and heavy metal, although their style drew from a variety of influences, including blues and folk music. Led Zeppelin have been credited as significantly impacting the nature of the music industry, particularly in the development of album-oriented rock (AOR) and stadium rock.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/9/9e/Led_Zeppelin_logo.svg"
            });
            Bands.Add(new Band()
            {
                Name = "Black Sabbath",
                Description = "Black Sabbath were an English rock band formed in Birmingham in 1968 by guitarist Tony Iommi, drummer Bill Ward, bassist Geezer Butler and vocalist Ozzy Osbourne. They are often cited as pioneers of heavy metal music.[1] The band helped define the genre with releases such as Black Sabbath (1970), Paranoid (1970), and Master of Reality (1971). The band had multiple line-up changes following Osbourne's departure in 1979, with Iommi being the only constant member throughout its history.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Black_Sabbath_logo.svg/2880px-Black_Sabbath_logo.svg.png"
            });
            Bands.Add(new Band()
            {
                Name = "Deep Purple",
                Description = "Deep Purple are an English rock band formed in London in 1968.[1] They are considered to be among the pioneers of heavy metal and modern hard rock,[2][3] but their musical approach has changed over the years.[4] Originally formed as a psychedelic rock and progressive rock band, they shifted to a heavier sound with their 1970 album Deep Purple in Rock.[5] Deep Purple, together with Led Zeppelin and Black Sabbath, have been referred to as the \"unholy trinity of British hard rock and heavy metal in the early to mid - seventies\". They were listed in the 1975 Guinness Book of World Records as \"the globe's loudest band\" for a 1972 concert at London\'s Rainbow Theatre[7][8] and have sold over 100 million albums worldwide",
                Image = "https://deep-purple.com/wp-content/uploads/2021/10/deep-purple_from_cover.png"
            });
            Bands.Add(new Band()
            {
                Name = "Judas Priest",
                Description = "Judas Priest are an English heavy metal band formed in Birmingham in 1969. They have sold over 50 million copies of their albums, and are frequently ranked as one of the greatest metal bands of all time. Despite an innovative and pioneering body of work in the latter half of the 1970s, the band had struggled with indifferent record production and a lack of major commercial success until 1980, when they rose to commercial success with the album British Steel.",
                Image = "https://judaspriest.com/images/2020/50-Heavy-Metal-Years-website-header.jpg"
            });
            Bands.Add(new Band()
            {
                Name = "Alice Cooper",
                Description = "Alice Cooper (born Vincent Damon Furnier, February 4, 1948)[1] is an American singer, songwriter, and actor whose career spans over 54 years. With a raspy voice and a stage show that features numerous props and stage illusions, including pyrotechnics, guillotines, electric chairs, fake blood, reptiles, baby dolls, and dueling swords,[2] Cooper is considered by music journalists and peers to be \"The Godfather of Shock Rock\".[3] He has drawn equally from horror films, vaudeville, and garage rock to pioneer a macabre and theatrical brand of rock designed to shock audiences.",
                Image = ""
            });
            Bands.Add(new Band()
            {
                Name = "Motörhead",
                Description = "Motörhead (/ˈmoʊtərhɛd/) were an English rock band formed in London in 1975 by Lemmy (lead vocals, bass), Larry Wallis (guitar) and Lucas Fox (drums). Lemmy was also the primary songwriter and only constant member. The band are often considered a precursor to the new wave of British heavy metal, which re-energised heavy metal in the late 1970s and early 1980s.[1] Though several guitarists and drummers have played in Motörhead, most of their best-selling albums and singles feature drummer Phil \"Philthy Animal\" Taylor and guitarist \"Fast\" Eddie Clarke.",
                Image = ""
            });
            Bands.Add(new Band()
            {
                Name = "Metallica",
                Description = "Metallica is an American heavy metal band. The band was formed in 1981 in Los Angeles by vocalist/guitarist James Hetfield and drummer Lars Ulrich, and has been based in San Francisco for most of its career.[1][2] The band's fast tempos, instrumentals and aggressive musicianship made them one of the founding \"big four\" bands of thrash metal, alongside Megadeth, Anthrax and Slayer. Metallica's current lineup comprises founding members and primary songwriters Hetfield and Ulrich, longtime lead guitarist Kirk Hammett and bassist Robert Trujillo. Guitarist Dave Mustaine (who went on to form Megadeth after being fired from the band) and bassists Ron McGovney, Cliff Burton and Jason Newsted are former members of the band.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Metallica_wordmark.svg/2880px-Metallica_wordmark.svg.png"
            });

            BindingContext = this;

            base.OnAppearing();
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectBand = e.CurrentSelection[0] as Band;
            await DisplayAlert(selectBand.Name, selectBand.Description, "OK");
        }
    }
}
