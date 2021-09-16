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
            <h2 style="text-align: center; font-size: 30pt">Чат с сотрудником</h2>
        </div>
    </div>

    <div id="chat" style="overflow: scroll; overflow-y: auto; overflow-x:hidden; width: 1100px;height: 260px">
        <table>
            <?php
            /* echo GridView::widget([
                'dataProvider'=>$dataProvider,
                'columns' => [
                    'id',
                    'message',
                ]
            ]);*/

            foreach ($rows as $row){
                echo "<tr><td><strong>({$row['name']})</strong></td><td>{$row['message']}</td></tr>";
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
