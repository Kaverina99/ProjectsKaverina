<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */
/* @var $model app\models\ContactForm */

use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use yii\captcha\Captcha;

$this->title = 'Заказ насосных агрегатов';

?>
<div class="site-contact">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Заказ насосных агрегатов</h2>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-12">


            <?php $form = ActiveForm::begin(['id' => 'order3-form']); ?>

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

            <?= $form->field($model, 'klimatIspolnAndKateg')->textInput() ?>

            <div class="form-row">
                <table width="100%">
                    <tr>
                        <td width="50%"><center><strong>Характеристики</strong></center></td>
                        <td width="25%"><center><strong>Минимальный</strong></center></td>
                        <td width="25%"><center><strong>Максимальный</strong></center></td>
                    </tr>
                    <tr>
                        <td width="50%">Давление в сальниковой камере, МПа</td>
                        <td width="25%">
                            <?= $form->field($model, 'temperOkrVozdukhaMin')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'temperOkrVozdukhaMax')->textInput() ?>
                        </td>
                    </tr>
                </table>
            </div>

            <?= $form->field($model, 'classVzryvoopasPomeshch')->textInput() ?>
            <?= $form->field($model, 'naznachNasosa')->textInput() ?>

            <div class="form-row">
                <table width="100%">
                    <tr>
                        <td width="40%"><center><strong>Характеристики</strong></center></td>
                        <td width="20%"><center><strong>Минимальный</strong></center></td>
                        <td width="20%"><center><strong>Максимальный</strong></center></td>
                        <td width="20%"><center><strong>Номинальный</strong></center></td>
                    </tr>
                    <tr>
                        <td width="40%">Давление в сальниковой камере, МПа</td>
                        <td width="20%">
                            <?= $form->field($model, 'raskhodMin')->textInput(['autofocus' => true]) ?>
                        </td>
                        <td width="20%">
                            <?= $form->field($model, 'raskhodMax')->textInput() ?>
                        </td>
                        <td width="20%">
                            <?= $form->field($model, 'raskhodNominal')->textInput() ?>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="form-row">
                <table width="100%">
                    <tr>
                        <td width="50%"><center><strong>Характеристики</strong></center></td>
                        <td width="25%"><center><strong>Перед входным патрубком</strong></center></td>
                        <td width="25%"><center><strong>После насоса (перед задвижкой)</strong></center></td>
                    </tr>
                    <tr>
                        <td width="50%">Давление в системе, МПа, изб.</td>
                        <td width="25%">
                            <?= $form->field($model, 'davlSistPeredVkhodom')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'davlSistPosleNasosa')->textInput() ?>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'naporPotrebPriNominalRaskh')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'kavitatsZapasSeti')->textInput(['autofocus' => true]) ?>
                </div>
            </div>

            <?= $form->field($model, 'namePerekachProdukta')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'obyemKontsentrTverVkl')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'tempRab')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'plotnostPriTempRab')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'vyazkostPriTempRab')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'yprugostParovPriTempRab')->textInput(['autofocus' => true]) ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'toksichnostPoGOST')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'classOpastPoGOST')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'vzryvoopasPoGOSTR')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'pH')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'polymerization')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'material')->textInput(['autofocus' => true]) ?>
            <?= $form->field($model, 'rezina')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'chastotaVrashc')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'podacha')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'napor')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'kavitatsZapas')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'KPD')->textInput(['autofocus' => true]) ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'moshchnostPotreb')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'typeElektrodv')->textInput() ?>
            <?= $form->field($model, 'ispolneniyePoVzryvozashch')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'moshchnost')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'napryazheniye')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'tiporazmer')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'chastotaVrashch2')->textInput(['autofocus' => true]) ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'zatvornayaZhidkost')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'akkumulyatorPruzhGidravl')->textInput() ?>
            <?= $form->field($model, 'holodilnikYpl')->textInput() ?>
            <?= $form->field($model, 'avtonomnyyeSist')->textInput() ?>
            <?= $form->field($model, 'agregatInPolnomObyeme')->textInput(['autofocus' => true]) ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'nasos')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'massaAgr')->textInput() ?>
                </div>
            </div>

            <div class="form-group">
                <?= Html::submitButton('Отправить', ['class' => 'btn btn-primary', 'name' => 'order3-button']) ?>
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
