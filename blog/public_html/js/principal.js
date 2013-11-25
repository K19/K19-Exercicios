var scrollTimeout = 0;
var isLoadingArticles = false;

$(document).ready(function() {
	$('#articles-container').on('click', '.show-comments', function(e) {
		$(this).parent().find('form, article').slideDown();
		$(this).hide();
	});
	
	// Trata o evento de clique no botão de menu adicionando uma classe
	// ao mesmo para indicar que o mesmo está expandido.
	$('#main-menu-btn').click(function(e) {
		e.stopPropagation();
		$(this).parent().find('ul').addClass('expanded').slideDown();
	});
	
	// Trata o evento de clique em qualquer área da página para contrair e 
	// remover a classe expanded do menu principal.
	$('html').click(function(e) {
		$('#main-header ul.expanded').removeClass('expanded').slideUp(400, function() {
		    $(this).removeAttr('style');
		});
	});
	
	$(window).scroll(function() {
		// Utilizando um timeout para evitar chamadas excessivas
		// à função afterScroll().
		clearTimeout(scrollTimeout);
		scrollTimeout = setTimeout(afterScroll, 500);
	});
	
	// Carregando os artigos assim que a página for carregada.
	loadArticles();
});

function afterScroll() {
	if (!isLoadingArticles && $('#lazy-load-point').isOnScreen()) {
		loadArticles();
	}
}

function loadArticles() {
	$.ajax({
		url: 'servico.php',
		dataType: 'html',
		beforeSend: function(jqXHR, settings) {
			isLoadingArticles = true;
	
			// Exibe o GIF animado que indica o carregamento do conteúdo.
			$('#lazy-load-point').addClass('loading');
		},
		complete: function() {
			// O uso do timeout neste ponto é desnecessário. Foi utilizado aqui
			// para dar tempo do GIF animado ser visualizado em um servidor 
			// local.
			setTimeout(function() {
				isLoadingArticles = false;
				// Oculta o GIF animado que indica o carregamento do conteúdo.
				$('#lazy-load-point').removeClass('loading');
			}, 1000);
		},
		success: function(data, textStatus, jqXHR) {
			// O uso do timeout neste ponto é desnecessário. Foi utilizado aqui
			// para dar tempo do GIF animado ser visualizado em um servidor 
			// local.
			setTimeout(function() {
				$('#articles-container').prepend(data);
			}, 1000);
		},
		error: function(jqXHR, textStatus, errorThrown) {
		    alert(errorThrown);
		}
	});
}

// Extendendo o jQuery com o método isOnScreen que verifica se um 
// elemento está na região visível da página.
$.fn.isOnScreen = function() {
	var win = $(window);

	var viewport = {
		top: win.scrollTop(),
		left: win.scrollLeft()
	};
	viewport.right = viewport.left + win.width();
	viewport.bottom = viewport.top + win.height();
	
	var bounds = this.offset();
	bounds.right = bounds.left + this.outerWidth();
	bounds.bottom = bounds.top + this.outerHeight();
	
	return (!(viewport.right < bounds.left || 
				viewport.left > bounds.right || 
				viewport.bottom < bounds.top || 
				viewport.top > bounds.bottom));
};