<?php

/* @var $this yii\web\View */

use yii\helpers\Html;

$this->title = 'Заказ';

?>
<div class="site-about">
<!--
        <div class="alert alert-success">
            <br/>
            Уважаемый клиент, благодарим Вас за заказ нашей продукции!
            Ваш заказ был успешно оформлен и уже передан на обработку нашим сотрудникам.
            <br/>По всем вопросам Вы можете обращаться в Чат с нашим сотрудником (для этого перейдите в Личный кабинет во вкладку Мои заказы) или по одному
            из контактных телефонов.
        </div>
-->



    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Заказ продукции </h2>
        </div>
    </div>

    <?php if(Yii::$app->user->isGuest): ?>
    <br/>
    <h3>Уважаемый Гость сайта, для оформления оналайн-заказа Вам необходимо пройти авторизацию. <br/>Для этого, пожалуйста, пройдите
        в раздел <a style="color: #0a73bb" href="/index.php?r=site/office">"Личный кабинет"</a> и зарегистрируйтесь или войдите, если у Вас уже есть аккаунт на нашем сайте. </h3>
        <br/> <br/> <br/>
    <?php else: ?>

    <br/>
    <h3>Наша продукция является технически сложным товаром. Для заказа, пожалуйста, воспользуйтесь одной из форм, чтобы мы могли подобрать
        продукцию под Ваши потребности. Для этого выберите соответствующий опросный лист.</h3>

    <br/>
    <h2 style="font-size: 22pt">Опросные листы:</h2>
    <ul>
        <li><a href="/index.php?r=site/order1"><h4>Торцевые уплотнения для насосов</h4></a></li>
        <li><a href="/index.php?r=site/order2"><h4>Торцевые уплотнения для реакторов и мешалок</h4></a></li>
        <li><a href="/index.php?r=site/order3"><h4>Насосные агрегаты</h4></a></li>
        <li><a href="/index.php?r=site/order4"><h4>Блок подшипниково-уплотнительный</h4></a></li>
        <li><a href="/index.php?r=site/order5"><h4>Подшипники скольжения</h4></a></li>
        <li><a href="/index.php?r=site/order6"><h4>Изготовление арматуры</h4></a></li>
    </ul>

    <?php endif; ?>

    <br/><br/><br/>
</div>
