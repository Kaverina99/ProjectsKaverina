<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */
/* @var $model app\models\LoginForm */

use yii\grid\GridView;
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;

$this->title = 'Чат';

?>
<div class="site-login">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Чат с клиентом</h2>
        </div>
    </div>

    <div id="chat" style="overflow: scroll; overflow-y: auto; overflow-x:hidden; width: 1100px;height: 260px">
        <table style="border-spacing: 7px 11px;">
            <?php
            /* echo GridView::widget([
                'dataProvider'=>$dataProvider,
                'columns' => [
                    'id',
                    'message',
                ]
            ]);*/

            foreach ($rows as $row){
                echo "<tr><td style='padding-right: 20px;'><strong>({$row['name']})</strong><br/><h6>{$row['datetime']}</h6></td><td><h3>{$row['message']}</h3></td></tr>";
            }

            ?>
        </table>
    </div>


    <?php $form = ActiveForm::begin(['class'=> 'form-horizontal']); ?>

    <div id='block' style="bottom: 0;">
        <?= $form->field($model, 'message')->textarea(['autofocus' => false])?>
        <?= Html::submitButton('Отправить', ['class' => 'btn btn-primary', 'name' => 'message-button']) ?>
    </div>

    <?php ActiveForm::end(); ?>

    <br/>
</div>
