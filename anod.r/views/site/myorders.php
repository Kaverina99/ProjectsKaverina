<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */

use app\models\User;
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use yii\grid\GridView;

$this->title = 'Мои заказы';

?>
<div class="site-login">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Мои заказы</h2>
        </div>
    </div>


    <br/>


    <?php echo GridView::widget([
        'dataProvider'=>$dataProvider,
        'columns' => [
            'id',
            'nameOrg',
            'FIO',
            'statusFK',
            ['class' => 'yii\grid\ActionColumn',
                'template' => '{view}']
        ]
    ]);

    ?>




    <br/><br/><br/>

</div>
