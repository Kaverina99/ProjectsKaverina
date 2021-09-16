<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */

use app\models\User;
use app\models\Zakaz;
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use yii\widgets\DetailView;

$this->title = 'Информация о заказе';

?>
<div class="site-login">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Информация о заказе</h2>
        </div>
    </div>


    <br/>

    <?php if ($model[sotrudnikFK] == Yii::$app->user->identity->getId()   ) : ?>
        <div class="form-group">
            <a href="/index.php?r=sotrudniki/chat" ><h4>Чат с клиентом</h4></a>
        </div>
    <?php endif; ?>
    <?php if ($model[sotrudnikFK] == 10 ) :
        $id = Yii::$app->user->identity->getId(); ?>

        <div class="form-group">
            <a href="/index.php?r=sotrudniki/vorder" ><h4>"Взять" заказ себе</h4></a>
        </div>
    <?php endif; ?>

    <h1>Контактная информация заказа:</h1>

    <?php
    echo DetailView::widget([
        'model'=>$model,
        'attributes' => [
            'id',
            'nameOrg',
            'addressOrg',
            'codeCity',
            'phone',
            'fax',
            'FIO',
            'position',
            'statusFK'
        ]
    ]);

    ?>


    <br/>
    <h1>Данные опросного листа:</h1>


    <?php
    echo DetailView::widget([
        'model'=>$model2,
        'attributes' => [
            'id', 'count', 'shtutsera', 'skhemaPromyvkiGOST', 'typeYplotn','markaNasosa','typeNasosa',
            'oborotyDvigatelya', 'napravlVrashchen', 'promyvSreda', 'temperPromyv','davlPromyv','classVzryvoopasZony',
            'markirovkaVzryvozashch', 'nameSreda', 'sostavSreda', 'pH','davlNaVkhodeMin','davlNaVkhodeMax',
            'davlNaNaporeMin', 'davlNaNaporeMax', 'davlInSalCameraMin', 'davlInSalCameraMax','temperMin','temperMax',
            'temperOkrSredaMin', 'temperOkrSredaMax', 'Dv', 'Dvt','D1','L1',
            'L2', 'D2', 'D3', 'Dsh','N','NalichieResKan'
        ]
    ]);

    ?>


    <br/><br/><br/>

</div>
