@RestController
class App{

	@RequestMapping("/")
	def home(){
		def header = "<html><body>"
		def footer = "</body></html>"
		def content = "<h1>Hello!</h1><p>thi is html content.</p>"
		
		header + content + footer
	}
}