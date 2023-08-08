@Grab("thymeleaf-spring4")
@Controller
class App{

	@RequestMapping("/")
	@ResponseBody
	def home(ModelAndView mav){
		mav.setViewName("home")
		mav.addObject("msg","Heool! this is sample page."))
	}
}