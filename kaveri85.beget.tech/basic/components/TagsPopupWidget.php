<?php 
namespace app\components;
use yii\base\Widget;

class TagsPopupWidget extends Widget {
	public function run() {
		$count_comment = \app\models\Comment::find()->select('post_FK, COUNT(post_FK) as sum')->asArray()->groupBy('post_FK')->orderBy('sum DESC')->all();

		$i=0;
		foreach ($count_comment as $key => $value) { 
			$tag = \app\models\TagPost::find()->select('tag_FK, post_FK')->asArray()->where(['post_FK' => $value['post_FK']])->all(); 
			foreach ($tag as $key => $tag_value) {
				$tag_popup[$i] = $tag_value['tag_FK'];
				$i++;
			}
		}
		$result = array_unique($tag_popup);

		echo '<div class="flexboxes">';
		foreach ($result as $key => $value) {
			$tags = \app\models\Tag::find()->select('*')->asArray()->where(['id' => $value])->all();

			foreach ($tags as $key2 => $tag) {
				if ($key < 3) {
					echo '<div class="flex_tag center_horiz"><p class="lead"><a href="/tag/'.$tag['alias'].'">'. $tag['title'] .'</a></p></div>';		
				}
			}
		}
		echo '</div>';
	
	}
}

?>