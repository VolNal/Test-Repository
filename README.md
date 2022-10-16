# About 
- Как скачать и установить JetBrains Rider
- Как клонировать репозиторий
- Как сделать коммит и сделать Pull Request с новой веткой

# Содержание

[Установка JetBrains Rider](#Install)  
[Как скачать репозиторий](#dowloads)  
[Делаем pull request](#commit)

<a name="Install"><h1>Установка JetBrains Rider</h1></a>

Установить(по инструкции) JetBrains Rider c сайта [rutracker](https://rutracker.org/forum/viewtopic.php?t=6225401) 
>Так-же при первом запуске сразу после активации зайти в настройки и отключить проверку обновлений(см. пикчу).
 <details>
 <summary>Пикчи в помощь</summary>

![alt-текст][updateoff]
![alt-текст][buttonopenplugins]
![alt-текст][plugins]
 
 [updateoff]: https://github.com/Alexandrjob/Tutorial/blob/main/pic/UpdateCheckOff.png "Окно отключения проверки обновлений"

[buttonopenplugins]: https://github.com/Alexandrjob/Tutorial/blob/main/pic/ButtonOpenPlugins.png "Кнопка открытия окна плагинов"

[plugins]: https://github.com/Alexandrjob/Tutorial/blob/main/pic/SerchPlugins.png "Окно плагинов"
</details>

___

### После успешной установки и запуска - установить плагины.
#### Обязательно:
* GitToolBox - позволяет видеть в файле кто и когда редактировал строки(и не только).
* Grazie - при написании комментариев ide не будет ругаться на русские слова.
* Key Promoter X - в окне сбоку будет видно какой hotkey отвечает за определенное действие.
* Rainbow Brackets - теперь большая вложенность не так сложна, а все потому что каждая пара скобок имеет разный цвет.
* Translation(автор - Yii.Guxing) - переводчик прямо в ide.
#### Необязательно:
* Atom Material File Icons - красивые иконки из Atom
* Material Theme UI Plugin - несколько тем на выбор.
* Nyan Progress Bar - просто необычный прогресс бар.
* WakaTime - тайм-трекер.

P.S. Лично мне не понравился шрифт и хоткеи, если надо будет сказать как поменять - скажи

<a name="dowloads"><h1>Как скачать репозиторий</h1></a>
 <details>
 <summary>Пикчи в помощь</summary>

![alt-текст][buttongetvcs]
![alt-текст][buttoncopy]
![alt-текст][pust]
 
 
[buttongetvcs]: https://github.com/Alexandrjob/Tutorial/blob/main/pic/ButtonGetVCS.png "Кнопка клонирования репозитория"

[buttoncopy]: https://github.com/Alexandrjob/Tutorial/blob/main/pic/CopyURL.png "Скопировать URL"

[pust]: https://github.com/Alexandrjob/Tutorial/blob/main/pic/PastURL.png "Вставить URL"
</details>

* При запуске riderа в окне нажать на кнопку "GET FROM VCS".
* Зайти в GitHub и скопировать url репозитория, в окне rider вставить в поле скопированный URL.
* Указать директорию, где мы будем хранить проект и нажать кнопку "CLONE".
* По завершению клонирования всплывет окно, там говорится что клонировать репозитории и запускать лучше с проверенных источников. Мы нажимаем "TRUST AND OPEN".

Теперь мы можем приступать с разработке. 

<a name="commit"><h1>Как создать коммит и добавить Pull Request с новой веткой</h1></a>
> работать с гит можно через консоль или через приложение. Мы будем работать через Rider.

#### Commit
* Создадать новую ветку, назвать newPic и поставить галочку на "Checkout branch".
* Открыть окно коммита, в этом окне выбрать файлы которые мы хотим обновить/добавить.
* Проверить что добавляем коммит в новую ветку.
* В поле Commit Massage написать описание коммита и нажать кнопку "COMMIT".
#### Push
* Открыть окно Push
* Еще раз проверить, что изменения отправляются в новую ветку.
* Проверить файлы, все ли были добавленны.
* Нажать кнопку "PUSH".   

#### Pull request
* Зайти на страницу главного репозитория.
* Зайти во вкладку Pull requests.
* Нажать на кнопку New pull request.
* В поле compare выберем ветку, которую хотим добавить.
* Нажимаем Create pull request.
