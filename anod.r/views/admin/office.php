<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */

use app\models\User;
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;

$this->title = 'Личный кабинет';

?>
<div class="site-login">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Личный кабинет</h2>
        </div>
    </div>


    <br/>
    <h3>Уважаемый Гость сайта, пожалуйста, авторизируйтесь. </h3><h3>Зарегистрируйтесь сейчас или войдите в систему с логиным и паролем. </h3>


    <br/>
    <div class="row">
        <div class="col-lg-5">

            <div class="form-group">

                <table width="30%">
                    <tr>
                        <td align="center"><a href="/index.php?r=admin/login" class="btn btn-primary">Войти</a></td>
                        <td align="center"><a href="/index.php?r=admin/signup" class="btn btn-primary">Зарегистрироваться</a></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <br/>

</div>
