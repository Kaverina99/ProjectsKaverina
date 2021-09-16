<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */
/* @var $model app\models\ContactForm */

use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use yii\captcha\Captcha;

$this->title = 'Заказ подшипниково-уплотнительных блоков';

?>
<div class="site-contact">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Заказ подшипниково-уплотнительных блоков</h2>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-12">

            <?php $form = ActiveForm::begin(['id' => 'order4-form']); ?>

            <?= $form->field($model, 'nameOrg')->textInput(['autofocus' => true]) ?>
            <?= $form->field($model, 'addressOrg')->textInput() ?>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'codeCity')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'fax')->textInput() ?>
                </div>
            </div>
            <?= $form->field($model, 'FIO')->textInput() ?>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'position')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'phone')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'count')->textInput() ?>

            <?= $form->field($model, 'markaModNasosa')->textInput() ?>
            <?= $form->field($model, 'proizvod')->textInput() ?>
            <?= $form->field($model, 'markaBPY')->textInput() ?>
            <?= $form->field($model, 'climatIspolnAndKateg')->textInput() ?>
            <?= $form->field($model, 'classVzryvoopasPomeshch')->textInput() ?>

            <div class="form-row">
                <table width="100%">
                    <tr>
                        <td width="50%"><center><strong>Характеристики</strong></center></td>
                        <td width="25%"><center><strong>Минимальный</strong></center></td>
                        <td width="25%"><center><strong>Максимальный</strong></center></td>
                    </tr>
                    <tr>
                        <td width="50%">Температура окружающего воздуха, °С</td>
                        <td width="25%">
                            <?= $form->field($model, 'tempOkrVozdukhaMin')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'tempOkrVozdukhaMax')->textInput() ?>
                        </td>
                    </tr>
                </table>
            </div>

            <?= $form->field($model, 'namePerekachZhid')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'tempRabPlotn')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'tempRabVyazkost')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'davlNasyshchParol')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'toksichPoGOST')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'classOpasPoGOST')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'vzryvoopasPoGOST')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'pH')->textInput() ?>
            <?= $form->field($model, 'polymerization')->textInput() ?>
            <?= $form->field($model, 'naznachNasosa')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'chastotaVrashch')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'napravlVrashch')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'podacha')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'napor')->textInput() ?>
                </div>
            </div>

            <div class="form-row">
                <table width="100%">
                    <tr>
                        <td width="50%"><center><strong>Характеристики</strong></center></td>
                        <td width="25%"><center><strong>Перед входным патрубком</strong></center></td>
                        <td width="25%"><center><strong>После насоса (перед задвижкой)</strong></center></td>
                    </tr>
                    <tr>
                        <td width="50%">Давление в системе, МПа (кгс/см2), изб.</td>
                        <td width="25%">
                            <?= $form->field($model, 'davlInSistPeredVkhod')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'davlInSistPosleNasosa')->textInput() ?>
                        </td>
                    </tr>
                </table>
            </div>


            <?= $form->field($model, 'sushchProblNasosa')->textInput() ?>
            <?= $form->field($model, 'nameZatvorZhidk')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'davlMPa')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'temperat')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'osobTrebovan')->textarea() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'typeElektrodvig')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'moshchnost')->textInput() ?>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'napryazheniye')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'chastotaVrashch2')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'BPYpoln')->textarea() ?>
            <?= $form->field($model, 'BPYnepoln')->textarea() ?>
            <?= $form->field($model, 'trebpvanKIPiA')->textarea() ?>


            <div class="form-group">
                <?= Html::submitButton('Отправить', ['class' => 'btn btn-primary', 'name' => 'order4-button']) ?>
            </div>
            <p><em>Нажимая кнопку "Отправить" Вы выражаете свою заинтересованность и даете полное согласие ООО НПЦ "АНОД"
                    на обработку (хранение и использование) Ваших персональных данных, без средств автоматизации, в соответствии
                    с Федеральным законом от 27.07.2006 года 152-ФЗ "О персональных данных".</em>
            </p>



            <?php ActiveForm::end(); ?>

            <br/><br/><br/>
        </div>
    </div>

</div>
