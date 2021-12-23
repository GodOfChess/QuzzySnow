using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeInfo : MonoBehaviour
{
    public List<Theme> themes;

    public List<Theme> GetThemes()
    {
        themes = new List<Theme>()
        {
            new Theme()
            {
                theme = "Биология"
            },
            new Theme()
            {
                theme = "Сетевые технологии"
            },
            new Theme()
            {
                theme = "Философия"
            },
            new Theme()
            {
                theme = "Литература"
            },
            new Theme()
            {
                theme = "Видеоигры"
            },
            new Theme()
            {
                theme = "Фильмы"
            },
            new Theme()
            {
                theme = "Музыка"
            }
        };
        return themes;
    }

    public List<Question> GetEasyList(string theme)
    {
        List<Question> qList = new List<Question>();
        if (theme == "Биология")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Наука цитология изучает живые объекты на уровне...",
                    answers = new string[] { "клеточном", "молекулярном", "популяционном" }
                },
                new Question()
                {
                    question = "Клетки многоклеточных зеленых водорослей...",
                    answers = new string[] { "обладают одинаковым строением", "приспособлены к выполнению функции прикрепления", "питаются разными способами" }
                },
                new Question()
                {
                    question = "Кость состоит из...",
                    answers = new string[] { "оба варианта верны", "органических веществ", "неорганических веществ"}
                },
                new Question()
                {
                    question = "Клетки организма собак запасают АТФ в...",
                    answers = new string[] { "митохондриях", "рибосомах", "ядрах" }
                },
                new Question()
                {
                    question = "Направляющим фактором эволюции является...",
                    answers = new string[] { "естественный отбор", "изменчивость", "борьба за существование" }
                },
                new Question()
                {
                    question = "Мерцательный эпителий расположен...",
                    answers = new string[] { "в носовой полости", "в верхнем слое кожи", "в стенках желудка" }
                },
            };
        }
        else if (theme == "Сетевые технологии")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Глобальной компьютерной сетью мирового уровня является:",
                    answers = new string[] { "WWW", "E-mail", "интранет" }
                },
                new Question()
                {
                    question = "Сервер, управляющий клиентским доступом к файлам называется:",
                    answers = new string[] { "файл-сервером", "почтовым", "прокси" }
                },
                new Question()
                {
                    question = "Cетевая топология определяется способом, структурой:",
                    answers = new string[] { "соединения узлов каналами сетевой связи", "аппаратного обеспечения", "программного обеспечения" }
                },
                new Question()
                {
                    question = "Протокол HTTP служит для:",
                    answers = new string[] { "передачи гипертекста", "передачи файлов", "управления передачи сообщениями" }
                },
                new Question()
                {
                    question = "Компьютер, подключенный к сети Internet, обязательно имеет...",
                    answers = new string[] { "IP-адрес", "WEB-страницу", "доменное имя" }
                },
                new Question()
                {
                    question = "Какая сеть называется региональной?",
                    answers = new string[] { "построенная на территории города или области", "охватывающая территорию страны или нескольких стран", "охватывающая небольшую территорию внутри отдельных контор, бирж, банков, учреждений" }
                },
            };
        }
        else if (theme == "Философия")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Рационально оформленная система взглядов человека на мир, на себя и на свое место в мире есть...",
                    answers = new string[] {"философия", "мифология", "религия"}
                },
                new Question()
                {
                    question = "Греческие слова phileo «любовь» и sophia «мудрость» дали начало термину...",
                    answers = new string[] {"философия", "эклектика", "гемофилия"}
                },
                new Question()
                {
                    question = "Согласно М. Хайдеггеру и Ж. П. Сартру, бытие, направленное к ничто и сознающее свою конечность, - это...",
                    answers = new string[] {"экзистенция", "мышление", "научный факт"}
                },
                new Question()
                {
                    question = "Человеческому сознанию присуще:",
                    answers = new string[] {"активная, творческая деятельность", "непосредственное воздействие на действительность", "порождение объективной реальности"}
                },
                new Question()
                {
                    question = "Какая статуя часто используется как символ философии?",
                    answers = new string[] {"«Мыслитель»", "«Будда»", "«Венера Милосская»"}
                },
                new Question()
                {
                    question = "Кто из русских писателей-классиков больше всего повлиял на развитие идеалистической философии в России?",
                    answers = new string[] {"Ф. М. Достоевский", "А. С. Пушкин", "Л. Н. Толстой"}
                },
            };
        }
        else if (theme == "Литература")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "К какому идейно-эстетическому направлению в литературе XVIII-XIX веков принадлежит «Бедная Лиза» Н.М. Карамзина?",
                    answers = new string[] { "сентиментализм", "классицизм", "критический реализм" }
                },
                new Question()
                {
                    question = "О каком произведении А.И. Куприна К. Паустовский писал: «Один из самых благоуханных рассказов о любви - и самых печальных.»",
                    answers = new string[] { "Гранатовый браслет", "Олеся", "Яма" }
                },
                new Question()
                {
                    question = "Перу какого писателя принадлежит повесть «Капитанская дочка»? Назовите автора этого произведения.",
                    answers = new string[] { "А.С. Пушкин", "М.Ю. Лермонтов", "А.С. Грибоедов" }
                },
                new Question()
                {
                    question = "Укажите название рассказа М. Горького, в котором представлены легенды, рассказывающие горькую правду о двойственном роде людском.",
                    answers = new string[] { "Старуха Изергиль", "Макар Чудра", "Челкаш" }
                },
                new Question()
                {
                    question = "К кому обращается А.С. Пушкин в строчках «Подруга дней моих суровых»?",
                    answers = new string[] { "К няне", "К матери", "К тетке" }
                },
                new Question()
                {
                    question = "Назовите основную проблему, поставленную М.А. Булгаковым в повести «Собачье сердце»",
                    answers = new string[] { "Ответственность человек за результаты своего труда и экспериментов", "Проблема охраны окружающей среды", "Проблема Отцов» и «Детей" }
                },
            };
        }
        else if (theme == "Видеоигры")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Кто главный герой в трилогии игр про Ведьмака?",
                    answers = new string[] { "Геральт", "Ламберт", "Весемир" }
                },
                new Question()
                {
                    question = "Какая компания создала серию GTA?",
                    answers = new string[] { "Rockstar", "Cd Project", "From software" }
                },
                new Question()
                {
                    question = "Саб-Зиро и Скорпион являются...",
                    answers = new string[] { "заклятыми врагами", "братьями", "отцом и сыном" }
                },
                new Question()
                {
                    question = "Ничто не истинно, все...",
                    answers = new string[] { "дозволено", "правильно", "неверно" }
                },
                new Question()
                {
                    question = "Так называются дополнения к основному сюжету игры",
                    answers = new string[] { "аддон", "апгрейд", "скилл" }
                },
                new Question()
                {
                    question = "Рыцарь смерти Артас был в ...",
                    answers = new string[] { "warcraft: frozen throne", "starcraft", "heroes of the storm" }
                },
            };
        }
        else if (theme == "Фильмы")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Кто главный герой в трилогии Властелина колец?",
                    answers = new string[] { "Фродо", "Гендальф", "Арагорн" }
                },
                new Question()
                {
                    question = "Агент 007 – это ...",
                    answers = new string[] { "Джеймс Бонд", "Джеймс Гордон", "Индиана Джонс" }
                },
                new Question()
                {
                    question = "Главный герой в «Операции “Ы”»?",
                    answers = new string[] { "Шурик", "Братья Карамазовы", "Раскольников" }
                },
                new Question()
                {
                    question = "Чарли Чаплин снимался в основном в...",
                    answers = new string[] { "комедиях", "драмах", "детективах" }
                },
                new Question()
                {
                    question = "Кого играл Марк Хэмилл в «Звездных войнах»?",
                    answers = new string[] { "Люк Скайуокер", "Дарт Вейдер", "Оби-Ван Кеноби" }
                },
                new Question()
                {
                    question = "В фильме «Криминальное чтиво» Квентин Тарантино ...",
                    answers = new string[] { "оба верны", "актёр", "режиссёр" }
                },
            };
        }
        else if (theme == "Музыка")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "С помощью чего изображаются звуки?",
                    answers = new string[] { "Ноты", "Символы", "Иероглифы" }
                },
                new Question()
                {
                    question = "Сколько нот существует?",
                    answers = new string[] { "7", "6", "5" }
                },
                new Question()
                {
                    question = "На какую песню The Beatles больше всего каверов?",
                    answers = new string[] { "Yesterday", "Get Back", "Something" }
                },
                new Question()
                {
                    question = "За какую песню Eminem получил премию «Оскар»?",
                    answers = new string[] { "Lose Yourself", "Real Slim Shady", "Rap God" }
                },
                new Question()
                {
                    question = "Кому принадлежит песня «Небеса»?",
                    answers = new string[] { "Валерий Меладзе", "Филипп Киркоров", "Сергей Лазарев" }
                },
                new Question()
                {
                    question = "Закончите строчку «We are the ...»",
                    answers = new string[] { "champions", "winners", "genius" }
                },
            };
        }
        return qList;
    }

    public List<Question> GetMediumList(string theme)
    {
        List<Question> qList = new List<Question>();
        if (theme == "Биология")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "У взрослого человека количество крови составляет...",
                    answers = new string[] { "5-6 литров", "3-4 литра", "6-7 литров" }
                },
                new Question()
                {
                    question = "Желчь необходима для переваривания...",
                    answers = new string[] { "жиров", "белков", "углеводов" }
                },
                new Question()
                {
                    question = "Надцарства выделяют, чтобы разделить живую природу на две группы:",
                    answers = new string[] { "прокариоты и эукариоты", "грибы и бактерии", "растения и животные" }
                },
                new Question()
                {
                    question = "В растительной клетке запасающую функцию выполняет...",
                    answers = new string[] { "крахмал", "гликоген", "целлюлоза" }
                },
                new Question()
                {
                    question = "Выберите простейшие организмы:",
                    answers = new string[] { "инфузория и хламидомонада", "гидра и эвглена", "бактерия и вольвокс" }
                },
                new Question()
                {
                    question = "Клетки данного типа ткани постоянно обновляются за счет быстрого деления клеток:",
                    answers = new string[] { "эпителиальная", "нервная", "соединительная" }
                },
            };
        }
        else if (theme == "Сетевые технологии")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Какой уровень модели OSI является программно-ориентированным?",
                    answers = new string[] { "сеансовый", "физический", "сетевой" }
                },
                new Question()
                {
                    question = "Для чего нужно поле преамбула в кадре Ethernet?",
                    answers = new string[] { "синхронизация передатчика и приемника", "контроль за ошибками в кадре", "определение типа кадра" }
                },
                new Question()
                {
                    question = "На каком уровне модели OSI работают коммутаторы?",
                    answers = new string[] { "канальный", "сетевой", "транспортный" }
                },
                new Question()
                {
                    question = "Технология Ethernet определяется стандартом ІЕЕЕ:",
                    answers = new string[] { "802.3", "802.2", "802.5" }
                },
                new Question()
                {
                    question = "Трафик, что наиболее критический к задержкам, это...",
                    answers = new string[] { "голосовой в реальном режиме", "мультимедийный", "текстовый" }
                },
                new Question()
                {
                    question = "С помощью чего коммутаторы осуществляют продвижение кадров по сети?",
                    answers = new string[] { "таблицы адресов", "ARP-таблицы", "таблицы маршрутизации" }
                },
            };
        }
        else if (theme == "Философия")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "В психоанализе среди скрытых основ души человека нет инстинкта:",
                    answers = new string[] {"социальности", "либидо", "смерти"}
                },
                new Question()
                {
                    question = "Раздел философии, изучающий фундаментальные принципы бытия – это:",
                    answers = new string[] {"онтология", "герменевтика", "социология"}
                },
                new Question()
                {
                    question = "Демокрит полагал началом всего сущего...",
                    answers = new string[] {"атомы", "огонь", "числа"}
                },
                new Question()
                {
                    question = "Доказательства бытия Бога разрабатывали представители:",
                    answers = new string[] {"схоластики", "логистики", "софистики"}
                },
                new Question()
                {
                    question = "Принцип разделения властей был сформулирован в работах...",
                    answers = new string[] {"Локка и Монтескье", "Галилея и Декарта", "Фейербаха и Маркса"}
                },
                new Question()
                {
                    question = "С точки зрения Й. Хейзинги, человек - это существо...",
                    answers = new string[] {"играющее", "рациональное", "изготавливающее орудия труда"}
                },
            };
        }
        else if (theme == "Литература")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Что хотел купить Дуглас Сполдинг из повести Р. Брэдбери «Вино из одуванчиков»?",
                    answers = new string[] { "новые туфли", "шоколадку", "книгу " }
                },
                new Question()
                {
                    question = "Это не нашло отражения в творчестве О. Уайльда",
                    answers = new string[] { "Социальная тема", "Стремление к красоте", "Искусство, свободное от морали" }
                },
                new Question()
                {
                    question = "Что не является произведением Стивена Кинга?",
                    answers = new string[] { "Хребты безумия", "под куполом", "игра Джералда" }
                },
                new Question()
                {
                    question = "Кто из представленных ниже писателей написал «Гроздья гнева»?",
                    answers = new string[] { "Д. Стейнбек", "У. Коллинз", "Д. Остин" }
                },
                new Question()
                {
                    question = "Персонажем какого произведения является Грегор Замза?",
                    answers = new string[] { "А. Ф. Кафка «Превращение»", "Б. А. Камю «Чума»", "В. Э. Хемингуэй «Старик и море»" }
                },
                new Question()
                {
                    question = "Главными героями какого романа Д. Джойса являются Стивен Дедалус и Леопольд Блум? ",
                    answers = new string[] { "Улисс", "Портрет художника в юности", "Поминки по Финнегану" }
                },
            };
        }
        else if (theme == "Видеоигры")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Игра года 2011",
                    answers = new string[] { "tes 5: Skyrim", "cod: modern warfare 3", "fifa 12" }
                },
                new Question()
                {
                    question = "Фраза: «Торт - ложь» из игры ...",
                    answers = new string[] { "portal", "bioshock", "gta" }
                },
                new Question()
                {
                    question = "В какой части NFS был черный список?",
                    answers = new string[] { "Most wanted", "Underground", "Heat" }
                },
                new Question()
                {
                    question = "Кто создал танк в игре Assasins Creed II?",
                    answers = new string[] { "Леонардо да Винчи", "Эцио Аудиторе", "Лоренцо Медичи" }
                },
                new Question()
                {
                    question = "Третье слово в крике «безжалостный крик» было ... ",
                    answers = new string[] { "дах", "дин", "шуль" }
                },
                new Question()
                {
                    question = "Сколько гоблинов у Techies в Dota 2?",
                    answers = new string[] { "2", "3", "1" }
                },
            };
        }
        else if (theme == "Фильмы")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Леонардо Ди Каприо получил «Оскар» за фильм ...",
                    answers = new string[] { "Выживший", "Начало", "Однажды в голливуде" }
                },
                new Question()
                {
                    question = "Хаяо Миядзаки снимает ...",
                    answers = new string[] { "аниме", "детективы", "ужасы" }
                },
                new Question()
                {
                    question = "Какая из этих игр имеет киноэкранизацию?",
                    answers = new string[] { "Assasins Creed", "Mass Effect", "StarCraft" }
                },
                new Question()
                {
                    question = "Сколько актеров играли Бэтмена в кино?",
                    answers = new string[] { "7", "8", "6" }
                },
                new Question()
                {
                    question = "Какой сериал снят по мотивам серии «Песнь льда и пламени»?",
                    answers = new string[] { "Игра престолов", "Сверхъестественное", "Ведьмак" }
                },
                new Question()
                {
                    question = "Геральт из Ривии - персонаж цикла книг ...",
                    answers = new string[] { "сага о ведьмаке", "песнь льда и пламени", "темная башня" }
                },
            };
        }
        else if (theme == "Музыка")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Песня Аллы Пугачевой без рифмы?",
                    answers = new string[] { "Старинные часы", "Маэстро", "Позови меня с собой" }
                },
                new Question()
                {
                    question = "Из скольки звуков состоит звукоряд?",
                    answers = new string[] { "88", "66", "76" }
                },
                new Question()
                {
                    question = "Сквидвард из мультсериала «Губка боб» играет на ...",
                    answers = new string[] { "Кларнет", "Флейта", "Гитара" }
                },
                new Question()
                {
                    question = "Что общего между гитарой и роялем?",
                    answers = new string[] { "Струны", "Клавиши", "Педали" }
                },
                new Question()
                {
                    question = "Наибольшее кол-во песен на 1-ом месте в «Billboard Hot 100» у ...",
                    answers = new string[] { "The Beatles", "Elvis Presley", "Rihanna" }
                },
                new Question()
                {
                    question = "С какой песней Дима Билан победил на Евровидении?",
                    answers = new string[] { "Believe", "Невозможно", "Never let you go" }
                },
            };
        }
        return qList;
    }

    public List<Question> GetHardList(string theme)
    {
        List<Question> qList = new List<Question>();
        if (theme == "Биология")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "К аналогичным органам относятся:",
                    answers = new string[] { "крылья летучей мыши и бабочки", "лапы ящерицы и лягушки", "лапы собаки и крота" }
                },
                new Question()
                {
                    question = "Выберите наименьшую систематическую категорию:",
                    answers = new string[] { "паслен черный", "двудольные", "покрытосеменные" }
                },
                new Question()
                {
                    question = "В ротовой полости происходит...",
                    answers = new string[] { "оба варианта верны", "только химическая обработка пищи", "только механическая обработка пищи" }
                },
                new Question()
                {
                    question = "Что создали Дж. Уотсон и Ф. Крик?",
                    answers = new string[] { "модель РНК", "клеточную теорию", "теорию мутагенеза" }
                },
                new Question()
                {
                    question = "Обмен веществ между кровью и тканями происходит в...",
                    answers = new string[] { "капиллярах", "венах", "мышцах" }
                },
                new Question()
                {
                    question = "Примерами гермафродитов являются...",
                    answers = new string[] { "кишечнополостные, черви, моллюски", "кишечнополостные, черви, рыбы", "кишечнополостные, черви, насекомые" }
                },
            };
        }
        else if (theme == "Сетевые технологии")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Дана маска подсети для класса С - 255.255.255.192. Сколько бит отводиться для адресации подсетей?",
                    answers = new string[] {"2", "24", "16"}
                },
                new Question()
                {
                    question = "Для чего нужен S кадр протокола HDLC?",
                    answers = new string[] { "восстановление кадров, потерянных из-за искажений в канале", "перенос пользовательской информации", "установление соединений и его разрушения" }
                },
                new Question()
                {
                    question = "Какой протокол преобразует IP-адрес в физический адрес?",
                    answers = new string[] { "ARP", "RARP", "DHCP" }
                },
                new Question()
                {
                    question = "Сколько максимум VLAN можно организовать в одном коммутаторе?",
                    answers = new string[] { "4096", "1024", "2048" }
                },
                new Question()
                {
                    question = "Работа какого моста основана на вкладывании кадра одного формата в кадр другого формата?",
                    answers = new string[] { "инкапсулирующий", "с маршрутизацией от источника", "прозрачный" }
                },
                new Question()
                {
                    question = "Что такое бит-стаффинг?",
                    answers = new string[] { "вставка дополнительного бита в кадр, для предотвращения ложного обнаружения флага", "удаление бита из кадра, для предотвращения ложного обнаружения флага", "вкладывание кадра одного формата в кадр другого формата"}
                },
            };
        }
        else if (theme == "Философия")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Кто называет 3 стадии развития общества: доиндустриальную, индустриальную, постиндустриальную?",
                    answers = new string[] { "Д. Белл", "Р. Мертон", "М. Фуко" }
                },
                new Question()
                {
                    question = "Указать, кто из ниже названных философов является приверженцем цивилизационной концепции общественного развития:",
                    answers = new string[] { "Данилевский Н.", "Вольтер Ф.", "Фейербах Л." }
                },
                new Question()
                {
                    question = "Кто из философов утверждал, что жизнь человека в сущности бессмысленна и абсурдна?",
                    answers = new string[] { "А. Камю", "А. Шопенгауэр", "М. Фуко" }
                },
                new Question()
                {
                    question = "Как называется вымышленная ситуация, не лишенная логики, которая не может существовать в реальности?",
                    answers = new string[] { "Апория", "Парадокс", "Солипсизм" }
                },
                new Question()
                {
                    question = "Мыслитель эпохи Возрождения, считавший, что правитель должен сочетать в себе качества льва и лисицы:",
                    answers = new string[] { "Макиавелли", "Петрарка", "Кампанелла" }
                },
                new Question()
                {
                    question = "Демократия, исходящая из идеи всеобщего равенства:",
                    answers = new string[] { "эгалитарная", "либеральная", "партийная" }
                }
            };
        }
        else if (theme == "Литература")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Своеобразие творческого метода ... заключается в импрессионистическом фиксировании субъективных впечатлений, расчленяющихся на мельчайшие частицы",
                    answers = new string[] { "М.Пруста", "Ф. Мориака", "Р.Роллана" }
                },
                new Question()
                {
                    question = "Автор сатирического романа «Гаргантюа и Пантарюэль»",
                    answers = new string[] { "Франсуа Рабле", "Мишель де Монтень", "Жан-Жак Буассар" }
                },
                new Question()
                {
                    question = "Кто создал сборник стихотворений «Цветы зла»?",
                    answers = new string[] { "Бодлер", "Шоу", "Уайльд" }
                },
                new Question()
                {
                    question = "В этом романе Г. Грина 1955 года действие происходит во время войны во Вьетнаме",
                    answers = new string[] { "Тихий американец", "Ведомство ужаса", "Наш человек в Гаване" }
                },
                new Question()
                {
                    question = "В романе «Миссис Дэллоуэй» В. Вульф действие укладывается в один день этого месяца",
                    answers = new string[] { "Июнь", "Июль", "Август" }
                },
                new Question()
                {
                    question = "Какое произведение Байрона стало его первым манифестом",
                    answers = new string[] { "Английские барды и шотландские обозреватели", "Часы досуга", "Паломничество Чайльд-Гарольда" }
                }
            };
        }
        else if (theme == "Видеоигры")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Чит-код HESOYAM используется для ...",
                    answers = new string[] { "деньги, оружие, здоровье", "снижение уровня розыска", "получение автомобиля" }
                },
                new Question()
                {
                    question = "Сколько маны стоит Meat Hook у Pudge?",
                    answers = new string[] { "110", "140", "120" }
                },
                new Question()
                {
                    question = "Фраза: «War. War never changes» из серии игр...",
                    answers = new string[] { "fallout", "dragon age", "call of duty" }
                },
                new Question()
                {
                    question = "Какой актер сыграл Джонни Сильверхенда?",
                    answers = new string[] { "Киану Ривз", "Элайджа Вуд", "Том Хиддлстон" }
                },
                new Question()
                {
                    question = "Самый первый босс в Terraria это ...",
                    answers = new string[] { "король слизней", "плантерра", "глаз ктулху" }
                },
                new Question()
                {
                    question = "Кто помогает вам при битве с гигантом Йормом в DS3?",
                    answers = new string[] { "Сигвард из Катарины", "Сэр Вильгельм", "Ирина из Каримы" }
                }
            };
        }
        else if (theme == "Фильмы")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Самый известный прием Стэнли Кубрика это ...",
                    answers = new string[] { "одноточечная перспектива", "эффект вертиго", "крупный план" }
                },
                new Question()
                {
                    question = "«Солярис», «Сталкер», «Андрей Рублёв» фильмы режиссера ...",
                    answers = new string[] { "Андрей Тарковский", "Андрей Кончаловский", "Тимур Родригез" }
                },
                new Question()
                {
                    question = "“Когда-то «сегодня» тоже называлось «завтра»” из фильма ...",
                    answers = new string[] { "Обмани меня", "Области тьмы", "Особо опасен" }
                },
                new Question()
                {
                    question = "Ханц Циммер композитор фильма ...",
                    answers = new string[] { "Интерстеллар", "Омерзительная восьмерка", "Мстители" }
                },
                new Question()
                {
                    question = "Фильм по реальным событиям?",
                    answers = new string[] { "Я Кристина", "Король Артур", "Око" }
                },
                new Question()
                {
                    question = "Фраза: «Не виноватая я, он сам пришёл!», из фильма ...",
                    answers = new string[] { "Бриллиантовая рука", "Джентльмены удачи", "Ирония судьбы" }
                }
            };
        }
        else if (theme == "Музыка")
        {
            qList = new List<Question>()
            {
                new Question()
                {
                    question = "Настоящее имя Фредди Меркьюри?",
                    answers = new string[] { "Фаррух Булсара", "Джон Меркури", "Стивен Шон" }
                },
                new Question()
                {
                    question = "В каком фильме была песня «Перемен» Виктора Цоя?",
                    answers = new string[] { "Асса", "Живой", "Игла" }
                },
                new Question()
                {
                    question = "Самое длинное гитарное соло принадлежит ...",
                    answers = new string[] { "Dragonforce", "Led Zeppelin", "AC/DC" }
                },
                new Question()
                {
                    question = "Самый быстрый рэпер в мире",
                    answers = new string[] { "Twista", "Eminem", "Machine Gun Kelly" }
                },
                new Question()
                {
                    question = "«Я — король скрипки, а гитара — моя королева» - сказал ...",
                    answers = new string[] { "Никколо Паганини", "Линдси Стерлинг", "Эдуард Грач" }
                },
                new Question()
                {
                    question = "Звуки отрывисто, отделяя один от другого паузами это ...",
                    answers = new string[] { "стаккато", "легато", "маркато" }
                }
            };
        }
        return qList;
    }
}

public class Theme
{
    public string theme;
    public List<Question> questionList;
}
