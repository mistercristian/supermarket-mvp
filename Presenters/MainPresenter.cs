using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCategoriaView += ShowCategoriaView;
            this.mainView.ShowProvidersView += ShowProvidersView;
            this.mainView.ShowProductView += ShowProductView;
        }

        private void ShowPayModeView(object? sender, EventArgs e) 
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }

        private void ShowCategoriaView(object? sender, EventArgs e)
        {
            
            ICategoriaView view = CategoriaView.GetInstance((MainView)mainView);
            ICategoriaRepository repository = new
    CategoriaRepository(sqlConnectionString);
            new CategoriaPresenter(view, repository);
        }

        private void ShowProvidersView(object? sender, EventArgs e)
        {
            
            IProvidersView view = ProvidersView.GetInstance((MainView)mainView);
            IProvidersRepository repository = new
    ProvidersRepository(sqlConnectionString);
            new ProvidersPresenter(view, repository);
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);

        }


    }
}
