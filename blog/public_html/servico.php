<?php for ($i = 0; $i < 3; $i++): ?>
	<article>
		<header>
			<h1>Lorem ipsum dolor sit <?php echo $i ?></h1>
			<h2>por Jonas Hirata</h2>
		</header>
		
		<div class="article-text">
			<figure>
				<img 
					src="img/paisagem.jpg" 
					title="Paisagem" 
					alt="Árvores ao redor de um lago no outono">
				<figcaption>Árvores ao redor de um lago no outono</figcaption>
			</figure>
			<p>
				Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
				Maecenas convallis viverra justo sed adipiscing. 
				Maecenas vitae arcu lectus. Praesent eleifend sapien et 
				consequat ultricies. Donec varius, leo a condimentum 
				porta, quam tortor lobortis metus, consectetur posuere 
				enim metus vitae lorem. In tempor gravida arcu in 
				sollicitudin. Nullam molestie, sem vitae volutpat 
				porta, ligula tortor pretium diam, sed adipiscing magna 
				massa ut nisl. Pellentesque congue nisl vehicula leo 
				tincidunt ultricies.
			</p>
		</div>
		
		<div class="article-comments">
			<input 
				class="show-comments" 
				type="button" 
				value="Comentar/Exibir comentários">
			
			<form>
				<fieldset>
					<legend>Deixe o seu comentário</legend>
					<input type="text" placeholder="Nome">
					<input type="email" placeholder="E-mail">
					<textarea placeholder="Comentários"></textarea>
					<input type="submit" value="Enviar">
				</fieldset>
			</form>
			
			<article>
				<small>Jonas Hirata</small>
				<p>
					Praesent eleifend egestas volutpat. Quisque quis 
					tortor ut odio adipiscing egestas sit amet ut 
					nisl. Vivamus venenatis turpis id nisl 
					facilisis, sed cursus odio scelerisque.
				</p>
			</article>
		</div>
	</article>
<?php endfor; ?>