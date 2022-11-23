<?php 
namespace app\components;
use yii\base\Widget;
use yii\helpers\Html;

class TagWidget extends Widget {
	public function run2($adm) {
		$tags = \app\models\Tag::find()->select('*')->asArray()->orderBy('title')->all();

		echo '<div>';
		foreach ($tags as $key => $tag) {
			echo '<div><p class="lead"><a href="/tag/'.$tag['alias'].'">'. $tag['title'] .'</a></p></div>';		
		}
		echo '</div>';
	
	}
}

?>