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
            <h2 style="text-align: center; font-size: 30pt">Информация о заказе №<?= "{$model['id']}" ?></h2>
        </div>
    </div>


    <br/>

    <div class="form-group">
        <a href="/index.php?r=site/message" ><h4>Чат с сотрудником</h4></a>
    </div>

    <h1>Контактная информация: </h1>

    <?php
    echo DetailView::widget([
        'model'=>$model,
        'attributes' => [
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
    <h3 >(<?= "{$type}" ?>)</h3>

    <?php
    echo DetailView::widget([
        'model'=>$model2,
        'attributes' => [
            'count', 'shtutsera', 'skhemaPromyvkiGOST', 'typeYplotn','markaNasosa','typeNasosa',
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
