<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */
/* @var $model app\models\ContactForm */

use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use yii\bootstrap\Modal;
use yii\captcha\Captcha;

$this->title = 'Контакты';
?>

<div class="site-contact">


    <?php if (Yii::$app->session->hasFlash('contactFormSubmitted')): ?>
        <div class="alert alert-success">
            <br/>
            Благодарим Вас за обращение. Наш сотрудник ответит Вам как можно скорее.
        </div>
    <?php endif; ?>

    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Контактная информация</h2>
        </div>
    </div>

    <h3>Головной офис и производство</h3>
    <strong>Адрес</strong>: ул. Свободы, 63, Нижний Новгород, Россия, 603003

    <br/><br/>
    <h3>Секретариат</h3>
    <strong>Телефон</strong>: (831) 233-77-03, 273-01-77<br/>
    <strong>Факс-автомат: </strong>(831) 273-01-78<br/>
    <strong>e-mail</strong>: <a href="mailto:info@anod.ru">info@anod.ru</a><br/>

    <br/>
    <h3>Работа с клиентами</h3>
    <h5>По торцовым уплотнениям</h5>
    <strong>Тел./факс</strong>: (831) 233-77-01,<br/>
    <strong>e-mail</strong>: <a href="mailto:market@anod.ru">market@anod.ru</a><br/>

    <br/>
    <h5>По насосным агрегатам</h5>
    <strong>Тел./факс</strong>: (831) 233-77-03, доб. 1-07, 1-48<br/>
    <strong>e-mail</strong>: <a href="mailto:nasos@anod.ru">nasos@anod.ru</a><br/>

    <br/>
    <h5>Социальные сети</h5>
    <strong>Facebook: </strong><a href="https://www.facebook.com/groups/anod.rpc/">https://www.facebook.com/groups/anod.rpc/</a><br/>
    <strong>вКонтакте: </strong><a href="http://vk.com/anod_nn">http://vk.com/anod_nn</a><br/>
    <strong>Twitter: </strong><a href="https://twitter.com/anod_nn">https://twitter.com/anod_nn</a><br/>
    <strong>Канал на Youtube: </strong><a href="https://www.youtube.com/channel/UCawD6Gs9c22IH2cYqyPRAEg">Канал АНОД</a><br/>

    <br/>
    <h3>ПЛАН ПРОЕЗДА</h3>

    <div class="cms-page-node">
        <script type="text/javascript" charset="utf-8" src="https://api-maps.yandex.ru/services/constructor/1.0/js/?sid=QrsD9AUe7k46lavr9FCk-Qs0NmzlTHTB&width=100%&height=637&lang=ru_RU&sourceType=constructor">
        </script></div>

    <br/>
    <h3>Реквизиты</h3>
    <strong>Общество с ограниченной ответственностью Научно-производственный центр "АНОД",<br />
            (ООО НПЦ "АНОД") г. Нижний Новгород </strong><br />
        Юридический адрес: Сормовское шоссе, 30, Нижний Новгород, Россия, 603014<br />
        Почтовый/фактический адрес: ул. Свободы, 63, Нижний Новгород, Россия, 603003<br />
        Тел.: (831) 233-77-03, 273-01-77, Факс: 273-01-78<br />
        ИНН 5259006834<br />
        КПП 525901001<br />
        Код ОКВЭД 25.99<br />
        Код ОКПО 25579857 ОГРН 1025202832775<br />
        р/с 40702810042070002747<br />
        Волго-Вятский банк ПАО Сбербанк г. Нижний Новгород<br />
        к/с 30101810900000000603<br />
        БИК 042202603<br />
        Генеральный директор Бородко Евгений Евгеньевич, действующий на основании Устава.

    <br/><br/>
    <h3>Региональные представительства</h3>
    ООО НПЦ "АНОД" имеет широкую дилерскую сеть в России, странах СНГ. Представительства есть в городах:
    <ul>
        <li><a href="http://anod-center.ru" target="_blank">г. Москва (Московская область, г. Химки)</a></li>
        <li><a href="http://anod-sev-zap.ru" target="_blank">г. Санкт-Петербург</a></li>
        <li><a href="http://anod-samara.ru" target="_blank">г. Самара</a></li>
        <li><a href="http://anod-bashkort.ru" target="_blank">г. Уфа</a></li>
        <li><a href="http://anod-tatarta.ru" target="_blank">г. Набережные Челны</a></li>
        <li><a href="http://anod-kama.ru" target="_blank">г. Пермь</a></li>
        <li><a href="http://anod-rostov.ru" target="_blank">г. Ростов-на-Дону</a></li>
        <li><a href="http://anod-sibir.ru" target="_blank">г. Новосибирск</a></li>
        <li><a href="http://anod-vostok.ru" target="_blank">г. Ангарск</a></li>
        <li><a href="http://neftemash-impex.ru" target="_blank">г. Хабаровск</a></li>
        <li><a href="http://anod-eu.ru" target="_blank">г. Клайпеда (Литва)</a></li>
        <li><a href="http://anod-eu.ru" target="_blank">г. София (Болгария)</a></li>
        <li>г. Волгоград</li>
        <li>г. Бобруйск (Беларусь)</li>
    </ul> <br/>

    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Обратная связь </h2>
        </div>
    </div>

    <h3>По всем возникающим вопросам Вы можете обратиться по одному из вышепредставленных телефонов организации или заполнив данную форму обратной связи.
        Наш сотрудик с радостью ответит на все Ваши вопросы.</h3>


    <div class="row">
        <div class="col-lg-5">

            <?php $form = ActiveForm::begin(['id' => 'contact-form']); ?>

            <?= $form->field($model, 'name')->textInput() ?>
            <?= $form->field($model, 'email') ?>
            <?= $form->field($model, 'subject') ?>
            <?= $form->field($model, 'text')->textarea(['rows' => 4]) ?>
            <div class="form-group">
                <?= Html::submitButton('Отправить', ['class' => 'btn btn-primary', 'name' => 'contact-button']) ?>
            </div>

            <?php ActiveForm::end(); ?>

        </div>
    </div>

    <br/><br/>
</div>
